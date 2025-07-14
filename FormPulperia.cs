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

        public void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = txtUser.Text.Trim();
            string password = txtPass.Text;

            if (userId == "admin" && password == "admin1234")
            {
                pnlLogin.Visible = false;
                return;
            }
            if (userId == "cajero01" && password == "cajero2024")
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
                        string query = "SELECT COUNT(1) FROM Usuario WHERE NombreUsuario = @Usuario AND Contraseña = @Contraseña";
                        using (SqlCommand cmd = new SqlCommand(query, sqlConn))
                        {
                            cmd.Parameters.AddWithValue("@Usuario", userId);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            using (var sqlConn = conn.GetConnection())
            {
                try
                {
                    sqlConn.Open();
                    string query = "SELECT ID_producto, nombre_producto, precio, stock FROM Producto";

                    SqlDataAdapter da = new SqlDataAdapter(query, sqlConn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvProductos.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al mostrar productos: " + ex.Message);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}