using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W06_02_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetPerson_Click(object sender, EventArgs e)
        {
            Data d = new Data();
            List<Person> list = d.GetPerson();
            listBoxPeople.DataSource = list;
        }

        private void buttonCountryFolder_Click(object sender, EventArgs e)
        {
            foreach (Person person in listBoxPeople.Items)
            {
                Directory.CreateDirectory("C:\\W06_02\\" + person.Country);
            }
        }

        private void buttonPersonFile_Click(object sender, EventArgs e)
        {
            foreach (Person person in listBoxPeople.Items)
            {
                FileStream fs = File.Create("C:\\W06_02\\" + person.Country+"\\"+person.FirstName+"_"+person.LastName+".txt");
                fs.Close();
            }
        }
    }
}
