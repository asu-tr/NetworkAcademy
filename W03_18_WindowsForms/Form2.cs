using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W03_18_WindowsForms
{
    public partial class Form2 : Form
    {
        public Form2(string str)
        {
            InitializeComponent();
            label1.Text = str;
        }
    }
}