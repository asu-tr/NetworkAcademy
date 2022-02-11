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
    public partial class Contacts : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        int UserID = 0;
        public Contacts(int id)
        {
            InitializeComponent();
            UserID = id;
        }

        private void Contacts_Load(object sender, EventArgs e)
        {
            RefreshContacts();
        }

        private void RefreshContacts()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Contacts Where UserID = " + UserID.ToString(), conn);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvContacts.DataSource = null;
            dgvContacts.DataSource = dt;

            dgvContacts.Columns["ContactID"].Visible = false;
            dgvContacts.Columns["UserID"].Visible = false;
        }

        private void dgvContacts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count == 1)
            {
                string name = dgvContacts.SelectedRows[0].Cells[1].Value.ToString();
                string phone = dgvContacts.SelectedRows[0].Cells[2].Value.ToString();

                textBoxName.Text = name;
                textBoxPhone.Text = phone;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string phone = textBoxPhone.Text;
            string id = dgvContacts.SelectedRows[0].Cells[0].Value.ToString();

            SqlCommand cmd = new SqlCommand("UpdateContact", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ContactID", id);
            cmd.Parameters.AddWithValue("@contactName", name);
            cmd.Parameters.AddWithValue("@phone", phone);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            RefreshContacts();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string question = "Do you want to delete " + dgvContacts.SelectedRows[0].Cells[1].Value.ToString();
            string caption = "Warning";

            DialogResult dr = MessageBox.Show(question, caption, MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                string id = dgvContacts.SelectedRows[0].Cells[0].Value.ToString();

                SqlCommand cmd = new SqlCommand("DeleteContact", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ContactID", id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                RefreshContacts();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddContact form = new FormAddContact(UserID);
            form.Show();
        }
    }
}
