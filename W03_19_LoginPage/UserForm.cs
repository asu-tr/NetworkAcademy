using System;
using System.Windows.Forms;

namespace W03_19_LoginPage
{
    public partial class UserForm : Form
    {
        public UserForm(User user)
        {
            InitializeComponent();

            string firstName = user.FirstName;
            string lastName = user.LastName;

            textBoxFirstName.Text = firstName;
            textBoxLastName.Text = lastName;

            buttonUpdate.Tag = user.ID;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DialogResult update 
                = MessageBox.Show("Do you really want to update?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(update == DialogResult.Yes)
            {
                int num = (int)buttonUpdate.Tag;

                int index = VirtualDB.users.FindIndex(u => u.ID == num);

                VirtualDB.users[index].FirstName = textBoxFirstName.Text;
                VirtualDB.users[index].LastName = textBoxLastName.Text;
            }
        }
    }
}