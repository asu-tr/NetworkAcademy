using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W04_04_DataGridView
{
    public partial class FormMain : Form
    {
        public static List<Customer> customers = new List<Customer>();

        public FormMain()
        {
            InitializeComponent();
            AddCustomers(30);
            dgvList.DataSource = customers;
            dgvList.Columns["Id"].Visible = false;
            dgvList.Columns[1].HeaderText = "First Name";
            dgvList.Columns[2].HeaderText = "Last Name";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string firstname = FakeData.NameData.GetFirstName();
            string lastname = FakeData.NameData.GetSurname();

        }

        public void AddCustomers(int count)
        {
            if (count > 0 )
            {
                for (int i = 0; i < count; i++)
                {
                    customers.Add(new Customer() { Id = i+1, Name = FakeData.NameData.GetFirstName(), Surname = FakeData.NameData.GetSurname(), Email = FakeData.NetworkData.GetEmail(), Phone = FakeData.PhoneNumberData.GetInternationalPhoneNumber(), City = FakeData.PlaceData.GetCity(), Country = FakeData.PlaceData.GetCountry(), Address = FakeData.PlaceData.GetAddress() });
                }
            }
            else
            {
                customers.Add(new Customer() { Id = 1, Name = FakeData.NameData.GetFirstName(), Surname = FakeData.NameData.GetSurname(), Email = FakeData.NetworkData.GetEmail(), Phone = FakeData.PhoneNumberData.GetInternationalPhoneNumber(), City = FakeData.PlaceData.GetCity(), Country = FakeData.PlaceData.GetCountry(), Address = FakeData.PlaceData.GetAddress() });
            }
            
        }
    }
}
