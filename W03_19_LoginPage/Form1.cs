using System;
using System.Drawing;
using System.Windows.Forms;

namespace W03_19_LoginPage
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            User user = VirtualDB.users.Find(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                UserForm uf = new UserForm(user);
                uf.Show();
                //uf.ShowDialog();
                this.Hide();
            }

            else
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxUsername_Enter(object sender, EventArgs e)
        {
            textBoxUsername.BackColor = GetColor();
        }

        private void textBoxUsername_Leave(object sender, EventArgs e)
        {
            textBoxUsername.BackColor = Color.White;
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = GetColor();
        }

        private System.Drawing.Color GetColor()
        {
            Random random = new Random();
            return Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.White;
        }
    }
}