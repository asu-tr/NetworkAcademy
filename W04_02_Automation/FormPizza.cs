using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W04_02_Automation
{
    public partial class FormPizza : Form
    {
        public FormPizza()
        {
            InitializeComponent();
        }

        private void FormPizza_Load(object sender, EventArgs e)
        {
            comboBoxSize.Items.Add(new Size() {SizeName = "Small", PriceRate = 1 });
            comboBoxSize.Items.Add(new Size() {SizeName = "Medium", PriceRate = 1.3 });
            comboBoxSize.Items.Add(new Size() {SizeName = "Large", PriceRate = 1.8 });
            comboBoxSize.SelectedIndex = 0;

            listBoxPizza.Items.Add(new Pizza() { Name = "Classic", Price = 16});
            listBoxPizza.Items.Add(new Pizza() { Name = "Garlic Chicken", Price = 17.95 });
            listBoxPizza.Items.Add(new Pizza() { Name = "Meatlover", Price = 19.95 });

            Crust classic = new Crust() { Name = "Classic", Price = 0 };
            Crust cheesy = new Crust() { Name = "Cheesy", Price = 3.5 };

            radioButtonClassic.Tag = classic;
            radioButtonCheesy.Tag = cheesy;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Pizza p = new Pizza();
            Pizza pi = (Pizza)listBoxPizza.SelectedItem;
            if (pi != null)
            {
                p.Name = pi.Name;
                p.Price = pi.Price;

                p.Size = (Size)comboBoxSize.SelectedItem;
                p.Price *= p.Size.PriceRate;
                p.Price = Math.Round(p.Price, 2);

                p.Crust = radioButtonClassic.Checked ? (Crust)radioButtonClassic.Tag : (Crust)radioButtonCheesy.Tag;
                p.Price += p.Crust.Price;

                p.Ingredients = new List<string>();
                foreach (CheckBox cb in groupBoxIng.Controls)
                {
                    if (cb.Checked)
                    {
                        p.Ingredients.Add(cb.Text);
                        p.Price += 1.2;
                    }
                }

                listBoxBasket.Items.Add(p);

                string price = labelTotalValue.Text.Substring(2);
                double total = Convert.ToSingle(price);

                total += p.Price;
                total = Math.Round(total, 2);
                labelTotalValue.Text = "$ " + total.ToString();
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.Pizzas = new List<Pizza>();
            o.Total = 0;

            foreach (Pizza p in listBoxBasket.Items)
            {
                o.Pizzas.Add(p);
                o.Total += p.Price;
            }

            richTextBoxOrders.Text = "";
            richTextBoxOrders.Text += o.ToString();

            listBoxBasket.Items.Clear();
            labelTotalValue.Text = "$ 0";
        }
    }
}