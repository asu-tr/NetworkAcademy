using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W06_09_ADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            // Windows Authentication
            sqlConnection.ConnectionString = "Server=localhost;Database=Northwind;Integrated Security=true;";
            // "Server=localhost;Database=Northwind;user=sth;pwd=123"

            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM Products";
            command.Connection = sqlConnection;

            sqlConnection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string ProductName = reader["ProductName"].ToString();
                string UnitPrice = reader["UnitPrice"].ToString();
                string UnitsInStock = reader["UnitsInStock"].ToString();

                listBox1.Items.Add(string.Format("{0}-{1}-{2}", ProductName, UnitPrice, UnitsInStock));
            }

            sqlConnection.Close();
        }

        private void buttonCat_Click(object sender, EventArgs e)
        {
            FormCategory formCategory = new FormCategory();
            formCategory.Show();
            this.Hide();
        }
    }
}
