namespace pulperia_mym
{
    public partial class FormPulperia : Form
    {
        public FormPulperia()
        {
            InitializeComponent();
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            string server = "TOMMY-MSI\\SQLEXPRESS01";
            string database = "Pulperia_MYM";
            string userId = txtUser.Text;
            string password = txtPass.Text;
            Connection connection = new Connection(server, database, userId, password);

            if (connection.Connected())
            {
                FormPulperia mainForm = new FormPulperia();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
