using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace pulperia_mym
{
    public partial class FormPulperia : Form
    {
        SqlConnection conexionGlobal;

        public FormPulperia()
        {
            InitializeComponent();

        }

        public SqlConnection ObtenerConexion()
        {
            string server = "DESKTOP-IL9GM8N\\DUENIS"; // tu instancia de SQL Server
            string database = "Pulperia_MYM";

            // Cadena de conexión con Trusted_Connection para Windows Authentication
            string connectionString = $"Server={server};Database={database};Trusted_Connection=True;";
            SqlConnection conexion = new SqlConnection(connectionString);
            return conexion;
        }


        public void btnLogin_Click(object sender, EventArgs e)
        {
            string server = "DESKTOP-IL9GM8N\\DUENIS";
            string database = "Pulperia_MYM";
            string userId = txtUser.Text.Trim();
            string password = txtPass.Text;

            // Verificación directa para el usuario admin (solo para prueba)
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

            string connectionString = $"Server={server};Database={database};User Id={userId};Password={password};TrustServerCertificate=True;";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    // Verificación más robusta
                    string query = "SELECT COUNT(1) FROM Usuario WHERE NombreUsuario = @Usuario AND Contraseña = @Contraseña";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT ID_producto, nombre_producto, precio, stock FROM Producto";

                    SqlDataAdapter da = new SqlDataAdapter(query, conexion);
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
    }
}
