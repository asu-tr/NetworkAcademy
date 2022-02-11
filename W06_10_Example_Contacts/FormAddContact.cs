using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W06_10_Example_Contacts
{
    public partial class FormAddContact : Form
    {
        string ID = "";
        public FormAddContact(int id)
        {
            InitializeComponent();
            string ID = id.ToString();
        }

        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string phone = textBoxPhone.Text;

            SqlCommand cmd = new SqlCommand("AddContact", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userID", ID);
            cmd.Parameters.AddWithValue("@contactName", name);
            cmd.Parameters.AddWithValue("@phone", phone);

            conn.Open();
            cmd.ExecuteNonQuery(); // i got an error here, check it next week
            conn.Close();
            this.Close();
        }
    }
}
