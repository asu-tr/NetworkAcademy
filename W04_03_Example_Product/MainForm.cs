using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace W04_03_Example_Product
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static List<Product> products = new List<Product>() { new Product() { ID = 1, Title = "Project Hail Mary", Author = "Andy Weir", Category = "Novel",  Image = Properties.Resources._1},
        new Product(){ ID = 2, Title = "Things We Never Got Over", Author = "Lucy Score", Category = "Novel", Image = Properties.Resources._2 },
        new Product() { ID = 3, Title = "Artemis", Author = "Andy Weir", Category = "Novel", Image =Properties.Resources._3 } };

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = products;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product p = (Product)comboBox1.SelectedItem;

            textBoxID.Text = p.ID.ToString();
            textBoxTITLE.Text = p.Title;
            textBoxAUTHOR.Text = p.Author;
            textBoxCAT.Text = p.Category;

            pictureBox1.Image = p.Image;
        }
    }
}