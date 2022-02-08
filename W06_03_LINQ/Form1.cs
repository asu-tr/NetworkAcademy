using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W06_03_LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSource ds = new DataSource();
        List<Customer> customers = new List<Customer>();

        private void buttonGet100_Click(object sender, EventArgs e)
        {
            listBoxFound.DataSource = null;
            customers = ds.Get100CustomerList();
            listBoxFound.DataSource = customers;
        }


        // With LINQ
        private void buttonFN_A_LINQ_Click(object sender, EventArgs e)
        {
            // int found = customers.Where(c => c.FirstName[0] == 'A').Count();

            customers = customers.Where(c => c.FirstName.StartsWith("A")).ToList();

            listBoxFound.DataSource = null;
            listBoxFound.DataSource = customers;
        }


        // LINQ to Query
        private void buttonFN_A_LINQ_ToQuery_Click(object sender, EventArgs e)
        {
            var foundCustomers = from C in customers where C.FirstName.StartsWith("A") select C;
            int foundCount = foundCustomers.Count();

            customers = foundCustomers.ToList();

            listBoxFound.DataSource = null;
            listBoxFound.DataSource = customers;
        }


        // BirthDate > 2010, FirstName contains A
        // LINQ to Query
        private void buttonBD_FN_Click(object sender, EventArgs e)
        {
            var foundCustomers = from C in customers
                                  where C.FirstName.ToUpper().Contains("A")
                                  && C.BirthDate.Year > 2010
                                  select C;

            customers = foundCustomers.ToList();

            listBoxFound.DataSource = null;
            listBoxFound.DataSource = customers;
        }


        // Historical :)
        public bool funcdelegatemethod(Customer c)
        {
            if (c.FirstName[0] == 'A')
            {
                return true;
            }
            else
                return false;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            customers = ds.Get100CustomerList();

            var startsWithA = customers.Where(C => C.FirstName.StartsWith("A"));

            Func<Customer, bool> funcdelegate = new Func<Customer, bool>(funcdelegatemethod);
            var startsWithA2 = customers.Where(funcdelegate);

            var startsWithA3 = customers.Where(delegate (Customer c)
            { return c.FirstName[0] == 'A' ? true : false; });
        }


        private void buttonAge18_Click(object sender, EventArgs e)
        {
            customers = customers.FindAll(c => c.BirthDate.Year > DateTime.Now.Year-18);

            listBoxFound.DataSource = null;
            listBoxFound.DataSource = customers;
        }


        // FN start B or LN contain E, BD > 2000
        // Query
        private void buttonFN_LN_BD_Click(object sender, EventArgs e)
        {
            var foundCustomers = from C in customers
                                 where (C.FirstName.StartsWith("A")
                                 || C.LastName.ToUpper().Contains("E"))
                                 && C.BirthDate.Year > 2000
                                 select C;

            customers = foundCustomers.ToList();

            listBoxFound.DataSource = null;
            listBoxFound.DataSource = customers;
        }

        private void buttonFE_Click(object sender, EventArgs e)
        {
            customers = customers.Where(C => C.Id % 2 == 0).ToList();
            listBoxFound.DataSource = null;

            customers.ForEach(x => listBoxFound.Items.Add((x.FirstName + " " + x.LastName).ToString()));
        }
    }
}
