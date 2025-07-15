using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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
        #endregion

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
    }
}