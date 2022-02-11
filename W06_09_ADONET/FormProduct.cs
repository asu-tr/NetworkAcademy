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

namespace W06_09_ADONET
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Server=.;Database=Northwind; Integrated Security=true;");

        SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        private void FormProduct_Load(object sender, EventArgs e)
        {
            RefreshProductTable();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            //string cmdText = string.Format("INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES ('{0}', {1}, {2})", textBoxProductName.Text, numericUpDownPrice.Value.ToString(), numericUpDownStock.Value.ToString());
            //SqlCommand cmd = new SqlCommand(cmdText, conn);

            string cmdTextSafe = string.Format("INSERT INTO Products (ProductName, UnitPrice, UnitsInStock) VALUES (@pname, @price, @stock)");

            SqlCommand cmd = new SqlCommand(cmdTextSafe, conn);

            cmd.Parameters.AddWithValue("@pname", textBoxProductName.Text);
            cmd.Parameters.AddWithValue("@price", numericUpDownPrice.Value.ToString());
            cmd.Parameters.AddWithValue("@stock", numericUpDownStock.Value.ToString());

            conn.Open();

            try
            {
                int rec = cmd.ExecuteNonQuery();

                if (rec > 0)
                {
                    MessageBox.Show("Product added succesfully.");
                    RefreshProductTable();
                }
                else
                    MessageBox.Show("An error occured.");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void RefreshProductTable()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Products WHERE Discontinued=0", conn);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = dt;
        }

        private void AddProductWithProc()
        {
            //not used in this pogram
            SqlCommand cmd = new SqlCommand("AddProductWithControl", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pName", textBoxProductName.Text);
            cmd.Parameters.AddWithValue("@price", numericUpDownPrice.Value.ToString());
            cmd.Parameters.AddWithValue("@stock", numericUpDownStock.Value.ToString());

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProduct();
            RefreshProductTable();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteProduct();
            RefreshProductTable();
        }

        private void DeleteProduct()
        {
            if (dataGridViewProducts.CurrentRow != null)
            {
                SqlCommand cmd = new SqlCommand("DeleteProductByName", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pName", dataGridViewProducts.CurrentRow.Cells["ProductName"].Value.ToString());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}