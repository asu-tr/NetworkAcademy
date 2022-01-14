using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03_20_Calculator
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        char opr = '0';
        int n1, result;

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            opr = '+';
            n1 = Convert.ToInt32(textBox.Text);
            textBox.Text = "";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            opr = '-';
            n1 = Convert.ToInt32(textBox.Text);
            textBox.Text = "";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            opr = '*';
            n1 = Convert.ToInt32(textBox.Text);
            textBox.Text = "";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            opr = '/';
            n1 = Convert.ToInt32(textBox.Text);
            textBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            switch (opr)
            {
                case '+':
                    result = n1 + Convert.ToInt32(textBox.Text);
                    textBox.Text = result.ToString();
                    break;
                case '-':
                    result = n1 - Convert.ToInt32(textBox.Text);
                    textBox.Text = result.ToString();
                    break;
                case '*':
                    result = n1 * Convert.ToInt32(textBox.Text);
                    textBox.Text = result.ToString();
                    break;
                case '/':
                    result = n1 / Convert.ToInt32(textBox.Text);
                    textBox.Text = result.ToString();
                    break;
                default:
                    textBox.Text = "ERROR";
                    break;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void button_Hover(object sender, EventArgs e)
        {
            this.BackColor = GetColor();
        }

        private System.Drawing.Color GetColor()
        {
            Random random = new Random();
            return Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));
        }

    }
}