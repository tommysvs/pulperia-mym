using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace pulperia_mym
{
    public class Connection
    {
        public string Server { get; set; }
        public string Database { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public Connection(string server, string database, string userId, string password)
        {
            Server = server;
            Database = database;
            UserId = userId;
            Password = password;
        }

        public bool Connected()
        {
            try
            {
                var conString = $"Server={Server};Database={Database};User Id={UserId};Password={Password};";

                var Con = new SqlConnection(conString);
                Con.Open();

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error connecting to the database. Please check your connection settings.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
