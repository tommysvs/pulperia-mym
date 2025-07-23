using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pulperia_mym
{
    public partial class FormPulperia : Form
    {
        private Connection conn;

        public FormPulperia()
        {
            InitializeComponent();
            conn = new Connection();
        }

        private void FormPulperia_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarTiposFactura();
            dateVencimiento.Enabled = false;
        }

        #region Login
        public void btnLogin_Click(object sender, EventArgs e)
        {
            string codigoUsuario = txtUser.Text.Trim();
            string password = txtPass.Text;

            if (codigoUsuario == "admin" && password == "admin1234")
            {
                pnlLogin.Visible = false;
                return;
            }
            if (codigoUsuario == "cajero01" && password == "cajero2024")
            {
                pnlLogin.Visible = false;
                return;
            }

            if (conn.Connected())
            {
                try
                {
                    using (var sqlConn = conn.GetConnection())
                    {
                        sqlConn.Open();
                        string query = "SELECT COUNT(1) FROM Usuario WHERE codigo_usuario = @Usuario AND contrasena = @Contraseña";
                        using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                        {
                            cmd.Parameters.AddWithValue("@Usuario", codigoUsuario);
                            cmd.Parameters.AddWithValue("@Contraseña", password);

                            int existe = (int)cmd.ExecuteScalar();

                            if (existe > 0)
                            {
                                pnlLogin.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Credenciales incorrectas", "Error");
                                txtPass.Text = "";
                                txtUser.Focus();
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error SQL: {ex.Message}", "Error de base de datos");
                }
            }
            else
            {
                txtPass.Text = "";
                txtUser.Focus();
            }
        }
        #endregion

        #region Ventas
        private void pnlRegFact_Paint(object sender, PaintEventArgs e)
        {
            dateVencimiento.Enabled = false;
        }

        private void CargarProductos()
        {
            using (SqlConnection conn = new SqlConnection("MEI\\SQLEXPRESS"))
            {
                string query = "SELECT IdProducto, Nombre FROM Producto";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbProductosFactura.DataSource = dt;
                cbProductosFactura.DisplayMember = "Nombre";
                cbProductosFactura.ValueMember = "IdProducto";
            }
        }

        private void CargarTiposFactura()
        {
            using (SqlConnection conn = new SqlConnection("MEI\\SQLEXPRESS"))
            {
                string query = "SELECT ID_tipo, NombreTipo FROM Tipo";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbTipoFactura.DataSource = dt;
                cbTipoFactura.DisplayMember = "NombreTipo";
                cbTipoFactura.ValueMember = "ID_tipo";
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgfactura.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);
            }
            lbltotal.Text = $"Total: L. {total:N2}";
        }

        private decimal ObtenerPrecio(int productoId)
        {
            using (SqlConnection conn = new SqlConnection("MEI\\SQLEXPRESS"))
            {
                string query = "SELECT Precio FROM Producto WHERE IdProducto = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", productoId);
                conn.Open();
                return (decimal)cmd.ExecuteScalar();
            }
        }

        private void rdbCreditoSi_CheckedChanged(object sender, EventArgs e)
        {
            dateVencimiento.Enabled = rdbCreditoSi.Checked;
        }

        private void rdbCreditoNo_CheckedChanged(object sender, EventArgs e)
        {
            dateVencimiento.Enabled = !rdbCreditoNo.Checked;
        }

        private void cbTipoFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("TU_CONEXION"))
            {
                string query = "SELECT ID_tipo, NombreTipo FROM Tipo";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbTipoFactura.DataSource = dt;
                cbTipoFactura.DisplayMember = "NombreTipo"; // O el campo que tengas
                cbTipoFactura.ValueMember = "ID_tipo";
            }
        }

        private void cbProductosFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("MEI\\SQLEXPRESS"))
            {
                string query = "SELECT IdProducto, Nombre FROM Producto";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbProductosFactura.DataSource = dt;
                cbProductosFactura.DisplayMember = "Nombre";
                cbProductosFactura.ValueMember = "IdProducto";
            }
        }

        private void btnAgregarFact_Click(object sender, EventArgs e)
        {
            if (cbProductosFactura.SelectedValue == null || nudCantidadFactura.Value < 1)
            {
                MessageBox.Show("Seleccione un producto y una cantidad válida.");
                return;
            }

            int id = (int)cbProductosFactura.SelectedValue;
            string nombre = cbProductosFactura.Text;
            int cantidad = (int)nudCantidadFactura.Value;
            decimal precio = ObtenerPrecio(id);
            decimal subtotal = cantidad * precio;

            dgfactura.Rows.Add(id, nombre, cantidad, precio, subtotal);
            CalcularTotal();
        }

        private void btnGuardarFact_Click(object sender, EventArgs e)
        {
            if (cbTipoFactura.SelectedValue == null || dgfactura.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar tipo de factura y agregar al menos un producto.");
                return;
            }

            decimal total = 0;
            foreach (DataGridViewRow row in dgfactura.Rows)
                total += Convert.ToDecimal(row.Cells["Subtotal"].Value);

            using (SqlConnection conn = new SqlConnection("MEI\\SQLEXPRESS"))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    SqlCommand cmdFactura = new SqlCommand(@"
                INSERT INTO Factura (codigo_interno, fecha, ID_tipo, credito, fecha_vencimiento_credito, total, total_pagado)
                OUTPUT INSERTED.ID_factura
                VALUES (@codigo, GETDATE(), @tipo, @credito, @vencimiento, @total, @pagado)", conn, trans);

                    cmdFactura.Parameters.AddWithValue("@codigo", Guid.NewGuid().ToString().Substring(0, 8));
                    cmdFactura.Parameters.AddWithValue("@tipo", cbTipoFactura.SelectedValue);
                    cmdFactura.Parameters.AddWithValue("@credito", rdbCreditoSi.Checked);
                    cmdFactura.Parameters.AddWithValue("@vencimiento", rdbCreditoSi.Checked ? dateVencimiento.Value : DBNull.Value);
                    cmdFactura.Parameters.AddWithValue("@total", total);
                    cmdFactura.Parameters.AddWithValue("@pagado", total);

                    int idFactura = (int)cmdFactura.ExecuteScalar();

                    foreach (DataGridViewRow row in dgfactura.Rows)
                    {
                        SqlCommand detalleCmd = new SqlCommand(@"
                    INSERT INTO DetalleFactura (IdFactura, ProductoId, Cantidad, PrecioUnitario)
                    VALUES (@factura, @producto, @cantidad, @precio)", conn, trans);

                        detalleCmd.Parameters.AddWithValue("@factura", idFactura);
                        detalleCmd.Parameters.AddWithValue("@producto", row.Cells["IdProducto"].Value);
                        detalleCmd.Parameters.AddWithValue("@cantidad", row.Cells["Cantidad"].Value);
                        detalleCmd.Parameters.AddWithValue("@precio", row.Cells["PrecioUnitario"].Value);
                        detalleCmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Factura registrada con éxito ✅");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error al guardar factura: " + ex.Message);
                }
            }
        }
        #endregion

        #region Productos
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNmbProducto.Text.Trim();
            string precio = txtPrecioProducto.Text;
            string stock = txtStockProducto.Text;

            using (var sqlConn = conn.GetConnection())
            {
                try
                {
                    sqlConn.Open();
                    string query = "INSERT INTO Producto (nombre_producto, precio, stock, activo) VALUES (@Nombre, @Precio, @Stock, @activo)";
                    using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombreProducto);
                        cmd.Parameters.AddWithValue("@Precio", precio);
                        cmd.Parameters.AddWithValue("@Stock", stock);
                        cmd.Parameters.AddWithValue("@Activo", 1);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto agregado correctamente.", "Éxito");
                            txtNmbProducto.Clear();
                            txtPrecioProducto.Clear();
                            txtStockProducto.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el producto.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar producto: " + ex.Message);
                }
            }
        }

        private void btnMostrarProducto_Click(object sender, EventArgs e)
        {
            using (var sqlConn = conn.GetConnection())
            {
                try
                {
                    sqlConn.Open();
                    string query = "SELECT ID_producto, nombre_producto, precio, stock FROM Producto WHERE activo = 1";

                    SqlDataAdapter da = new SqlDataAdapter(query, sqlConn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvProductos.DataSource = dt;

                    dgvProductos.Columns["ID_producto"].HeaderText = "Código";
                    dgvProductos.Columns["nombre_producto"].HeaderText = "Producto";
                    dgvProductos.Columns["precio"].HeaderText = "Precio";
                    dgvProductos.Columns["stock"].HeaderText = "Stock";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar productos: " + ex.Message);
                }
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un producto para eliminarlo.", "Aviso");
                return;
            }

            int idProducto = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells["ID_producto"].Value);

            var confirm = MessageBox.Show("¿Estás seguro de eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            using (var sqlConn = conn.GetConnection())
            {
                try
                {
                    sqlConn.Open();
                    string query = "UPDATE Producto SET activo = 0 WHERE ID_producto = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                    {
                        cmd.Parameters.AddWithValue("@ID", idProducto);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto eliminado correctamente.", "Éxito");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el producto.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                }
            }
        }
        #endregion

        #region Solicitud de productos
        private void btnCancelarSoli_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Clear();
            txtCantidadProducto.Clear();
            txtDescProducto.Clear();
        }

        private void btnMostrarSolicitud_Click(object sender, EventArgs e)
        {
            using (var sqlConn = conn.GetConnection())
            {
                try
                {
                    sqlConn.Open();
                    string query = "SELECT ID_solicitud, nombre_producto, cantidad, descripcion, fecha_solicitud FROM SolicitudProducto ORDER BY fecha_solicitud DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, sqlConn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvSolicitud.DataSource = dt;

                    dgvSolicitud.Columns["ID_solicitud"].HeaderText = "Código";
                    dgvSolicitud.Columns["nombre_producto"].HeaderText = "Producto";
                    dgvSolicitud.Columns["cantidad"].HeaderText = "Cantidad";
                    dgvSolicitud.Columns["descripcion"].HeaderText = "Descripción";
                    dgvSolicitud.Columns["fecha_solicitud"].HeaderText = "Fecha";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar solicitudes: " + ex.Message);
                }
            }
        }

        private void btnEnviarSoli_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombreProducto.Text.Trim();
            string cantidadTexto = txtCantidadProducto.Text.Trim();
            string descripcion = txtDescProducto.Text.Trim();

            if (string.IsNullOrEmpty(nombreProducto) || string.IsNullOrEmpty(cantidadTexto))
            {
                MessageBox.Show("Por favor complete todos los campos requeridos.", "Advertencia");
                return;
            }

            if (!int.TryParse(cantidadTexto, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero.", "Error");
                return;
            }

            using (var sqlConn = conn.GetConnection())
            {
                try
                {
                    sqlConn.Open();
                    string query = "INSERT INTO SolicitudProducto (nombre_producto, cantidad, descripcion, fecha_solicitud) VALUES (@Nombre, @Cantidad, @Descripcion, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombreProducto);
                        cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Solicitud enviada correctamente.", "Éxito");
                            txtNombreProducto.Clear();
                            txtCantidadProducto.Clear();
                            txtDescProducto.Clear();

                        }
                        else
                        {
                            MessageBox.Show("No se pudo enviar la solicitud.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al enviar solicitud: " + ex.Message);
                }
            }
        }
        #endregion

        #region Configuracion
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            string codigoUsuario = txtUsuarioConfig.Text.Trim();
            string nombreUsuario = txtNombreConfig.Text.Trim();
            string contrasena = txtPasswordConfig.Text;
            string rol = txtRolConfig.Text.Trim();

            using (var sqlConn = conn.GetConnection())
            {
                try
                {
                    sqlConn.Open();

                    string checkQuery = "SELECT COUNT(1) FROM Usuario WHERE codigo_usuario = @Codigo";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, sqlConn))
                    {
                        checkCmd.Parameters.AddWithValue("@Codigo", codigoUsuario);
                        int existe = (int)checkCmd.ExecuteScalar();

                        if (existe > 0)
                        {
                            MessageBox.Show("El usuario ya existe.", "Aviso");
                            return;
                        }
                    }

                    string query = "INSERT INTO Usuario (codigo_usuario, nombre_usuario, contrasena, rol, activo) VALUES (@Codigo, @Nombre, @Contrasena, @Rol, @Activo)";
                    using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                    {
                        cmd.Parameters.AddWithValue("@Codigo", codigoUsuario);
                        cmd.Parameters.AddWithValue("@Nombre", nombreUsuario);
                        cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                        cmd.Parameters.AddWithValue("@Rol", rol);
                        cmd.Parameters.AddWithValue("@Activo", 1);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Usuario agregado correctamente.", "Éxito");
                            txtUsuarioConfig.Clear();
                            txtNombreConfig.Clear();
                            txtStockProducto.Clear();
                            txtRolConfig.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el usuario.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar usuario: " + ex.Message);
                }
            }
        }

        private void btnMostrarUsuarios_Click(object sender, EventArgs e)
        {
            using (var sqlConn = conn.GetConnection())
            {
                try
                {
                    sqlConn.Open();
                    string query = "SELECT codigo_usuario, nombre_usuario, rol, activo FROM Usuario WHERE activo = 1";

                    SqlDataAdapter da = new SqlDataAdapter(query, sqlConn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvUsuarios.DataSource = dt;

                    dgvUsuarios.Columns["codigo_usuario"].HeaderText = "Usuario";
                    dgvUsuarios.Columns["nombre_usuario"].HeaderText = "Nombre";
                    dgvUsuarios.Columns["rol"].HeaderText = "Rol";
                    dgvUsuarios.Columns["activo"].HeaderText = "Activo";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar usuarios: " + ex.Message);
                }
            }
        }

        private void btnCamPassUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario para cambiar la contraseña.", "Aviso");
                return;
            }

            string codigoUsuario = dgvUsuarios.SelectedRows[0].Cells["codigo_usuario"].Value.ToString();
            string nuevaContrasena = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese la nueva contraseña para el usuario seleccionado:",
                "Cambiar contraseña",
                ""
            );

            if (string.IsNullOrWhiteSpace(nuevaContrasena))
            {
                MessageBox.Show("Debe ingresar una contraseña válida.", "Advertencia");
                return;
            }

            using (var sqlConn = conn.GetConnection())
            {
                try
                {
                    sqlConn.Open();
                    string query = "UPDATE Usuario SET contrasena = @Contrasena WHERE codigo_usuario = @Codigo";
                    using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                    {
                        cmd.Parameters.AddWithValue("@Contrasena", nuevaContrasena);
                        cmd.Parameters.AddWithValue("@Codigo", codigoUsuario);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Contraseña actualizada correctamente.", "Éxito");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar la contraseña.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cambiar la contraseña: " + ex.Message);
                }
            }
        }

        private void btnInactivarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un usuario para inactivar.", "Aviso");
                return;
            }

            string codigoUsuario = dgvUsuarios.SelectedRows[0].Cells["codigo_usuario"].Value.ToString();

            var confirm = MessageBox.Show(
                "¿Está seguro que desea inactivar este usuario?",
                "Confirmar inactivación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (confirm != DialogResult.Yes)
                return;

            using (var sqlConn = conn.GetConnection())
            {
                try
                {
                    sqlConn.Open();
                    string query = "UPDATE Usuario SET activo = 0 WHERE codigo_usuario = @Codigo";
                    using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                    {
                        cmd.Parameters.AddWithValue("@Codigo", codigoUsuario);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Usuario inactivado correctamente.", "Éxito");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo inactivar el usuario.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al inactivar usuario: " + ex.Message);
                }
            }
        }
        #endregion

        #region Reportes
        private void btnGenerarGraficos_Click(object sender, EventArgs e)
        {
            string consulta = @"
        SELECT 
            codigo_interno AS Producto,
            COUNT(*) AS CantidadVendida,
            SUM(total) AS TotalVenta
        FROM Factura
        WHERE codigo_interno IS NOT NULL
        GROUP BY codigo_interno
        ORDER BY CantidadVendida DESC;";

            using (var sqlConn = conn.GetConnection())
            {
                SqlCommand cmd = new SqlCommand(consulta, sqlConn);
                conn.GetConnection();

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                dgvMasvendido.DataSource = dt;

                chVentasGastos.Series.Clear();
                chVentasSemanales.Series.Clear();

                Series pieSeries = new Series("Ventas Pie");
                pieSeries.ChartType = SeriesChartType.Pie;

                Series barSeries = new Series("Ventas Barra");
                barSeries.ChartType = SeriesChartType.Column;

                foreach (DataRow row in dt.Rows)
                {
                    string producto = row["Producto"].ToString();
                    int cantidad = Convert.ToInt32(row["CantidadVendida"]);
                    decimal total = Convert.ToDecimal(row["TotalVenta"]);

                    pieSeries.Points.AddXY(producto, cantidad);
                    barSeries.Points.AddXY(producto, total);
                }

                chVentasGastos.Series.Add(pieSeries);
                chVentasSemanales.Series.Add(barSeries);
            }
        }
        #endregion
    }
}