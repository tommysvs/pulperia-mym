using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace pulperia_mym
{
    public partial class FormPulperia : MaterialForm
    {
        private Connection conn;

        public FormPulperia()
        {
            InitializeComponent();
            conn = new Connection();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Blue200, Accent.LightBlue200,
                TextShade.WHITE
            );

            tabMenu.Paint += matTabGeneral_Paint;

            SetHandCursorForMaterialButtons(this);

            CargarClientes();
            CargarClientes();
            CargarProductos();
            CargarTiposFactura();
            LimpiarSeccionFactura();
        }

        private void FormPulperia_Load(object sender, EventArgs e)
        {
            
        }

        #region MaterialSkin
        private void matTabGeneral_Paint(object sender, PaintEventArgs e)
        {
            var tabControl = sender as TabControl;
            if (tabControl == null) return;

            int tabHeight = tabControl.ItemSize.Height;
            using (var pen = new Pen(Color.LightBlue, 2))
            {
                e.Graphics.DrawLine(
                    pen,
                    0,
                    tabHeight + 1,
                    tabControl.Width,
                    tabHeight + 1
                );
            }
        }

        private void SetHandCursorForMaterialButtons(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is MaterialSkin.Controls.MaterialButton)
                {
                    control.Cursor = Cursors.Hand;
                }
                // Si el control tiene hijos, aplicar recursivamente
                if (control.HasChildren)
                {
                    SetHandCursorForMaterialButtons(control);
                }
            }
        }
        #endregion

        #region Eventos
        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDescuento.Text, out decimal value))
            {
                if (value < 0 || value > 100)
                {
                    MessageBox.Show("El descuento debe ser un porcentaje entre 0 y 100.");
                    txtDescuento.Text = "";
                }
            }
            else if (!string.IsNullOrEmpty(txtDescuento.Text))
            {
                MessageBox.Show("Ingrese solo números para el descuento.");
                txtDescuento.Text = "";
            }
        }

        private void txtCantidadFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LimpiarSeccionFactura()
        {
            dgvFactura.Rows.Clear();

            txtCantidadFactura.Clear();
            txtPrecio.Clear();
            txtDescuento.Text = "0";
            cbCliente.SelectedIndex = -1;
            cbProductosFactura.SelectedIndex = -1;

            lblSubtotal.Text = "Subtotal: L. 0.00";
            lblImpuesto.Text = "Impuesto (15%): L. 0.00";
            lblTotal.Text = "Total: L. 0.00";
        }
        #endregion

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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Inicio
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
        }
        #endregion

        #region Ventas
        private void CargarClientes()
        {
            using (var sqlConn = conn.GetConnection())
            {
                string query = "SELECT ID_cliente, nombre_completo FROM Cliente WHERE activo = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlConn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbCliente.DataSource = dt;
                cbCliente.DisplayMember = "nombre_completo";
                cbCliente.ValueMember = "ID_cliente";
            }
        }

        private void CargarProductos()
        {
            using (var sqlConn = conn.GetConnection())
            {
                string query = "SELECT ID_producto, nombre_producto, precio FROM Producto WHERE activo = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlConn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbProductosFactura.DataSource = dt;
                cbProductosFactura.DisplayMember = "nombre_producto";
                cbProductosFactura.ValueMember = "ID_producto";
            }
        }

        private void CargarTiposFactura()
        {
            using (var sqlConn = conn.GetConnection())
            {
                string query = "SELECT ID_tipo, descripcion FROM Tipo";
                SqlDataAdapter da = new SqlDataAdapter(query, sqlConn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbTipoFactura.DataSource = dt;
                cbTipoFactura.DisplayMember = "descripcion";
                cbTipoFactura.ValueMember = "ID_tipo";
            }
        }

        private void cbProductosFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProductosFactura.SelectedItem is DataRowView row)
            {
                txtPrecio.Text = row["precio"].ToString();
            }
            else
            {
                txtPrecio.Text = "";
            }
        }

        private void btnAgregarProdFact_Click(object sender, EventArgs e)
        {
            int cantidadFactura;
            if (!int.TryParse(txtCantidadFactura.Text, out cantidadFactura) || cantidadFactura < 1)
            {
                MessageBox.Show("Ingrese una cantidad válida (número entero mayor a 0).");
                return;
            }

            if (cbProductosFactura.SelectedValue == null || cantidadFactura < 1)
            {
                MessageBox.Show("Seleccione un producto y una cantidad válida.");
                return;
            }

            string producto = cbProductosFactura.Text;
            int cantidad = cantidadFactura;
            decimal precio = Convert.ToDecimal(txtPrecio.Text);
            decimal descuento = string.IsNullOrEmpty(txtDescuento.Text) ? 0 : Convert.ToDecimal(txtDescuento.Text);
            decimal subtotal = cantidad * precio;
            decimal impuesto = subtotal * 0.15m;
            decimal total = 0;

            dgvFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFactura.Rows.Add(producto, cantidad, precio, descuento, subtotal, impuesto);

            foreach (DataGridViewRow row in dgvFactura.Rows)
            {
                total += Convert.ToDecimal(row.Cells["subtotal"].Value);
            }

            lblSubtotal.Text = $"Subtotal: L. {total:N2}";
            lblImpuesto.Text = $"Impuesto (15%): L. {total * 0.15m:N2}";
            lblTotal.Text = $"Total: L. {total:N2}";
        }

        private void btnGuardarFact_Click(object sender, EventArgs e)
        {
            if (cbTipoFactura.SelectedValue == null || cbCliente.SelectedValue == null || dgvFactura.Rows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar cliente, tipo de factura y agregar al menos un producto.");
                return;
            }

            decimal total = 0;
            foreach (DataGridViewRow row in dgvFactura.Rows)
            {
                if (row.Cells["subtotal"].Value != null)
                    total += Convert.ToDecimal(row.Cells["subtotal"].Value);
            }

            using (var sqlConn = conn.GetConnection())
            {
                sqlConn.Open();
                SqlTransaction trans = sqlConn.BeginTransaction();

                bool esCredito = false;
                if (cbTipoFactura.SelectedItem is DataRowView tipoRow)
                    esCredito = tipoRow["descripcion"].ToString().Equals("Crédito", StringComparison.OrdinalIgnoreCase);

                try
                {
                    SqlCommand cmdVenta = new SqlCommand(@"
                        INSERT INTO Venta (codigo_interno, fecha, ID_tipo, ID_cliente, ID_usuario, credito, fecha_vencimiento_credito, total, total_pagado)
                        OUTPUT INSERTED.ID_venta
                        VALUES (@codigo, GETDATE(), @tipo, @cliente, @usuario, @credito, @vencimiento, @total, @pagado)", sqlConn, trans);

                    cmdVenta.Parameters.AddWithValue("@codigo", Guid.NewGuid().ToString().Substring(0, 8));
                    cmdVenta.Parameters.AddWithValue("@tipo", cbTipoFactura.SelectedValue);
                    cmdVenta.Parameters.AddWithValue("@cliente", cbCliente.SelectedValue);
                    cmdVenta.Parameters.AddWithValue("@usuario", 2); 
                    cmdVenta.Parameters.AddWithValue("@credito", esCredito);
                    cmdVenta.Parameters.AddWithValue("@vencimiento", esCredito ? dateVencimiento.Value : DBNull.Value);
                    cmdVenta.Parameters.AddWithValue("@total", total);
                    cmdVenta.Parameters.AddWithValue("@pagado", total);

                    int idVenta = (int)cmdVenta.ExecuteScalar();

                    foreach (DataGridViewRow row in dgvFactura.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int idProducto = 0;
                        using (var buscarConn = conn.GetConnection())
                        {
                            buscarConn.Open();
                            var buscarCmd = new SqlCommand("SELECT ID_producto FROM Producto WHERE nombre_producto = @nombre", buscarConn);
                            buscarCmd.Parameters.AddWithValue("@nombre", row.Cells[0].Value.ToString());
                            var result = buscarCmd.ExecuteScalar();
                            idProducto = result != null ? Convert.ToInt32(result) : 0;
                        }

                        SqlCommand detalleCmd = new SqlCommand(@"
                            INSERT INTO Venta_detalle (ID_venta, ID_producto, cantidad, cantidad_dec, ID_unidad, precio_unitario, descuento)
                            VALUES (@venta, @producto, @cantidad, @cantidad_dec, @id_unidad, @precio, @descuento)", sqlConn, trans);

                        detalleCmd.Parameters.AddWithValue("@venta", idVenta);
                        detalleCmd.Parameters.AddWithValue("@producto", idProducto);
                        detalleCmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row.Cells[1].Value));
                        detalleCmd.Parameters.AddWithValue("@cantidad_dec", 0);
                        detalleCmd.Parameters.AddWithValue("@id_unidad", 1);
                        detalleCmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(row.Cells[2].Value));
                        detalleCmd.Parameters.AddWithValue("@descuento", Convert.ToDecimal(row.Cells[3].Value));

                        detalleCmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Venta registrada con éxito.");

                    LimpiarSeccionFactura();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error al guardar venta: " + ex.Message);
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
                            btnMostrarProducto_Click(null, null);
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
                    dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar productos: " + ex.Message);
                }
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un producto para modificar.", "Aviso");
                return;
            }

            var row = dgvProductos.SelectedRows[0];
            int idProducto = Convert.ToInt32(row.Cells["ID_producto"].Value);
            string nombreActual = row.Cells["nombre_producto"].Value?.ToString() ?? "";
            string precioActual = row.Cells["precio"].Value?.ToString() ?? "";
            string stockActual = row.Cells["stock"].Value?.ToString() ?? "";

            string nuevoNombre = Microsoft.VisualBasic.Interaction.InputBox(
                "Nombre del producto:", "Modificar producto", nombreActual);

            if (string.IsNullOrWhiteSpace(nuevoNombre))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Advertencia");
                return;
            }

            string nuevoPrecio = Microsoft.VisualBasic.Interaction.InputBox(
                "Precio del producto:", "Modificar producto", precioActual);

            if (string.IsNullOrWhiteSpace(nuevoPrecio))
            {
                MessageBox.Show("El precio no puede estar vacío.", "Advertencia");
                return;
            }

            string nuevoStock = Microsoft.VisualBasic.Interaction.InputBox(
                "Stock del producto:", "Modificar producto", stockActual);

            if (string.IsNullOrWhiteSpace(nuevoStock))
            {
                MessageBox.Show("El stock no puede estar vacío.", "Advertencia");
                return;
            }

            using (var sqlConn = conn.GetConnection())
            {
                try
                {
                    sqlConn.Open();
                    string query = @"UPDATE Producto 
                        SET nombre_producto = @Nombre, precio = @Precio, stock = @Stock 
                        WHERE ID_producto = @ID";

                    using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nuevoNombre);
                        cmd.Parameters.AddWithValue("@Precio", nuevoPrecio);
                        cmd.Parameters.AddWithValue("@Stock", nuevoStock);
                        cmd.Parameters.AddWithValue("@ID", idProducto);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto modificado correctamente.", "Éxito");
                            btnMostrarProducto_Click(null, null);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar el producto.", "Error");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar producto: " + ex.Message);
                }
            }
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
                            btnMostrarProducto_Click(null, null);
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

                    dgvSolicitud.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

                    dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            Connection conexion = new Connection();

            using (SqlConnection con = conexion.GetConnection())
            {
                con.Open();

                // ===========================
                // 1. GRÁFICO DE PIE: VENTAS vs GASTOS
                // ===========================
                SqlCommand cmdVentas = new SqlCommand("SELECT ISNULL(SUM(total), 0) FROM Venta", con);
                decimal totalVentas = Convert.ToDecimal(cmdVentas.ExecuteScalar());

                SqlCommand cmdGastos = new SqlCommand(@"
            SELECT ISNULL(SUM(cd.costo * ISNULL(cd.cantidad, 0)), 0)
            FROM Compra_detalle cd
            JOIN Compra c ON cd.ID_compra = c.ID_compra", con);
                decimal totalGastos = Convert.ToDecimal(cmdGastos.ExecuteScalar());

                chVentasGastos.Series.Clear();
                chVentasGastos.Series.Add("GastosVsVentas");
                chVentasGastos.Series["GastosVsVentas"].ChartType = SeriesChartType.Pie;
                chVentasGastos.Series["GastosVsVentas"].IsValueShownAsLabel = true;

                chVentasGastos.Series["GastosVsVentas"].Points.AddXY("Ventas", totalVentas);
                chVentasGastos.Series["GastosVsVentas"].Points.AddXY("Gastos", totalGastos);

                // ===========================
                // 2. GRÁFICO DE BARRAS: VENTAS POR DÍA DE LA SEMANA (TODAS LAS VENTAS)
                // ===========================
                SqlCommand cmdDias = new SqlCommand(@"
                SELECT 
                    DATENAME(WEEKDAY, fecha) AS Dia, 
                    COUNT(*) AS Cantidad
                FROM Venta
                WHERE fecha IS NOT NULL
                GROUP BY DATENAME(WEEKDAY, fecha), DATEPART(WEEKDAY, fecha)
                ORDER BY DATEPART(WEEKDAY, fecha)", con);

                SqlDataReader reader = cmdDias.ExecuteReader();

                chVentasSemanales.Series.Clear();
                chVentasSemanales.Series.Add("VentasPorDia");
                chVentasSemanales.Series["VentasPorDia"].ChartType = SeriesChartType.Column;
                chVentasSemanales.Series["VentasPorDia"].IsValueShownAsLabel = true;

                while (reader.Read())
                {
                    string dia = reader["Dia"].ToString().ToLowerInvariant();
                    int cantidad = Convert.ToInt32(reader["Cantidad"]);
                    chVentasSemanales.Series["VentasPorDia"].Points.AddXY(dia, cantidad);
                }

                reader.Close();

                // ===========================
                // 3. DGV: PRODUCTOS MÁS VENDIDOS
                // ===========================
                string consultaTopProd = @"
            SELECT 
                p.nombre_producto AS Producto,
                SUM(vd.cantidad) AS VecesVendido,
                SUM(vd.cantidad * vd.precio_unitario) AS TotalVendido
            FROM Venta_detalle vd
            JOIN Producto p ON vd.ID_producto = p.ID_producto
            GROUP BY p.nombre_producto
            ORDER BY VecesVendido DESC;";

                SqlCommand cmdTopProd = new SqlCommand(consultaTopProd, con);
                DataTable dtTopProd = new DataTable();
                dtTopProd.Load(cmdTopProd.ExecuteReader());
                dgvMasvendido.DataSource = dtTopProd;
                dgvMasvendido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                con.Close();
            }
        }
        #endregion
    }
}