using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace pulperia_mym
{
    public class Connection
    {
        private const string server = @"DESKTOP-ANSMD3B";
        private const string database = "Pulperia_MYM";

        public Connection() { }

        public bool Connected()
        {
            try
            {
                var conString = $"Server={server};Database={database};Trusted_Connection=True;TrustServerCertificate=True;";
                using (var con = new SqlConnection(conString))
                {
                    con.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error connecting to the database. Please check your connection settings.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public SqlConnection GetConnection()
        {
            var conString = $"Server={server};Database={database};Trusted_Connection=True;TrustServerCertificate=True;";
            return new SqlConnection(conString);
        }
    }
}