using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03_21_GroupBox
{
    public partial class Form2 : Form
    {
        public Form2(string fn, string ln, string p, string e)
        {
            InitializeComponent();
            labelFN.Text = fn;
            labelLN.Text = ln;
            labelP.Text = p;
            labelE.Text = e;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }
    }
}
