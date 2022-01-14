using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03_21_GroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Customer> customers = new List<Customer>();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //listBoxCustomer.Items.Add(new Customer() { FirstName = textBoxFirstname.Text, LastName = textBoxLastname.Text, Phone = textBoxPhone.Text, Email = textBoxEmail.Text });
            customers.Add(new Customer() { FirstName = textBoxFirstname.Text, LastName = textBoxLastname.Text, Phone = textBoxPhone.Text, Email = textBoxEmail.Text });
            listBoxCustomer.DataSource = null;
            listBoxCustomer.DataSource = customers;
            listBoxCustomer.DisplayMember = "FirstName";
            listBoxCustomer.ValueMember = "Email";

            ClearTextBoxes(this.Controls);
        }

        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }
    }
}