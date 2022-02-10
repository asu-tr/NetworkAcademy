using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace W06_09_ADONET
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=.;Database=Northwind; Integrated Security=true;");

            // Disconnected
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Categories", sqlConnection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.Columns["CategoryID"].Visible = false;
        }
    }
}
