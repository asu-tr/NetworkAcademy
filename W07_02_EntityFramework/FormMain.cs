using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W07_02_EntityFramework
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        NorthwindDataContext ctx = new NorthwindDataContext();

        private void FormMain_Load(object sender, EventArgs e)
        {
            FillGridWithLambda();

            FillGridWithLINQ();

            comboCat.DataSource = ctx.Categories;
            comboCat.DisplayMember = "CategoryName";
            comboCat.ValueMember = "CategoryID";

            comboSup.DataSource = ctx.Suppliers;
            comboSup.DisplayMember = "CompanyName";
            comboSup.ValueMember = "SupplierID";
        }

        private void FillGridWithLINQ()
        {
            var result = from p in ctx.Products
                         join c in ctx.Categories
                         on p.CategoryID equals c.CategoryID
                         join s in ctx.Suppliers
                         on p.SupplierID equals s.SupplierID
                         select new
                         {
                             p.ProductID,
                             p.ProductName,
                             p.UnitPrice,
                             p.UnitsInStock,
                             p.CategoryID,
                             c.CategoryName,
                             s.CompanyName
                         };

            dgv.DataSource = result;
        }

        private void FillGridWithLambda()
        {
            RefreshDGV();
            dgv.Columns[0].Visible = false;
            dgv.Columns["SupplierID"].Visible = false;
            dgv.Columns["CategoryID"].Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.ProductName = textBoxProductName.Text;
            p.UnitPrice = nudPrice.Value;
            p.UnitsInStock = (short)nudStock.Value;
            p.CategoryID = (int)comboCat.SelectedValue;
            p.SupplierID = (int)comboSup.SelectedValue;

            ctx.Products.InsertOnSubmit(p);
            ctx.SubmitChanges();

            RefreshDGV();
        }

        private void RefreshDGV()
        {
            ctx = new NorthwindDataContext();
            dgv.DataSource = ctx.Products.Where(p => p.Discontinued == false);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxProductName.Text = dgv.CurrentRow.Cells["ProductName"].Value.ToString();
            textBoxProductName.Tag = dgv.CurrentRow.Cells["ProductID"].Value;
            nudPrice.Value = (decimal)dgv.CurrentRow.Cells["UnitPrice"].Value;
            nudStock.Value = (short)dgv.CurrentRow.Cells["UnitsInStock"].Value;
            if (dgv.CurrentRow.Cells["CategoryID"].Value != null)
            {
                comboCat.SelectedValue = dgv.CurrentRow.Cells["CategoryID"].Value;
            }
            if (dgv.CurrentRow.Cells["SupplierID"].Value != null)
            {
                comboSup.SelectedValue = dgv.CurrentRow.Cells["SupplierID"].Value;
            }            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id = (int)textBoxProductName.Tag;

            Product p = ctx.Products.First(pr => pr.ProductID == id);
            // Product p = ctx.Products.SingleOrDefault(x => x.ProductID == id);
            p.ProductName = textBoxProductName.Text;
            p.UnitPrice = nudPrice.Value;
            p.UnitsInStock = (short)nudStock.Value;
            p.CategoryID = (int)comboCat.SelectedValue;
            p.SupplierID = (int)comboSup.SelectedValue;

            ctx.SubmitChanges();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id = (int)textBoxProductName.Tag;

            Product p = ctx.Products.First(pr => pr.ProductID == id);

            ctx.Products.DeleteOnSubmit(p);
            ctx.SubmitChanges();

            RefreshDGV();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = ctx.Products.Where(p => p.ProductName.Contains(textBoxSearch.Text) && p.Discontinued == false);
        }
    }
}
