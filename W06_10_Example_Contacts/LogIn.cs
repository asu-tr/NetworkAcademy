using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace W06_10_Example_Contacts
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string pwd = textBoxPwd.Text;

            string cmdTextSafe = string.Format("SELECT UserID FROM Users Where Username = @username AND Password = @pwd");
            SqlCommand cmd = new SqlCommand(cmdTextSafe, conn);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("pwd", pwd);

            conn.Open();

            var userFound = cmd.ExecuteScalar();  

            conn.Close();

            if (userFound != null)
            {
                int userFoundInt = Convert.ToInt32(userFound);
                Contacts contacts = new Contacts(userFoundInt);
                contacts.Show();
                this.Hide();
            }
            

        }

        private void textBoxPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogIn.PerformClick();
            }
        }
    }
}
