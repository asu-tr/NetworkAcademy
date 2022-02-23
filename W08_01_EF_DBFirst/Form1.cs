using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W08_01_EF_DBFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
        }

        NorthwindEntities ne = new NorthwindEntities();

        private void Form1_Load(object sender, EventArgs e)
        {
            //DGVRefresh();

            ListProducts();

            cmbCat.DataSource = ne.Categories.ToList();
            cmbCat.DisplayMember = "CategoryName";
            cmbCat.ValueMember = "CategoryID";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Products p = new Products();
            p.ProductName = textBoxProductName.Text;
            p.UnitPrice = nud.Value;
            p.CategoryID = (int)cmbCat.SelectedValue;

            ne.Products.Add(p);
            ne.SaveChanges();
            DGVRefresh();
        }

        private void DGVRefresh()
        {
            dgv.DataSource = ne.Products.ToList();
        }

        private void ListProducts()
        {
            var products = ne.Products.Join(
                ne.Categories,
                p => p.CategoryID,
                c => c.CategoryID,
                (prd, ctg) => new
                {
                    prd.ProductID,
                    prd.ProductName,
                    prd.UnitPrice,
                    ctg.CategoryName
                }).ToList();

            var products2 = ne.Products.Join(
                ne.Categories,
                p => p.CategoryID,
                c => c.CategoryID,
                (prd, ctg) => new
                {
                    prd.ProductID,
                    prd.ProductName,
                    prd.UnitPrice,
                    prd.SupplierID,
                    ctg.CategoryName
                }).Join(ne.Suppliers,
                pc => pc.SupplierID,
                s => s.SupplierID,
                (product, sup) => new
                {
                    product.ProductID,
                    product.ProductName,
                    product.UnitPrice,
                    sup.CompanyName
                }).ToList();

            dgv.DataSource = products2;

            if (radioBtnDes.Checked)
            {
                dgv.DataSource = products2.OrderByDescending(x => x.UnitPrice); ;
            }

            dgv.DataSource = products2;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = ne.Products.Where(x => x.ProductName.Contains(textBoxProductName.Text)).ToList();
        }
    }
}