using NorthwindEntity;
using Nor
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
            txtProductName.Tag = dataGridView1.CurrentRow.Cells["ProductID"].Value;

            nudPrice.Value = (decimal)dataGridView1.CurrentRow.Cells["Price"].Value;
            nudStock.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["UnitsInStock"].Value);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.ProductID = (int)txtProductName.Tag;
            p.ProductName = txtProductName.Text;
            p.UnitPrice = nudPrice.Value;
            p.UnitsInStock = (short)nudStock.Value;
            p.CategoryID = (int)cmbCat.SelectedValue;
            p.SupplierID = (int)cmbSupplier.SelectedValue;
            p.QuantityPerUnit = "";
            ProductORM orm = new ProductORM();
        }
    }
}
