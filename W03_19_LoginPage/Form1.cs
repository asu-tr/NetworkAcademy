using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03_19_LoginPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            User u = VirtualDB.users.Find(u => u.Username == username && u.Password == password);

            if (u != null)
            {
                UserForm uf = new UserForm();
                uf.Show();
                this.Hide();
            }
        }
    }
}
