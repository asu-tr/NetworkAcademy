using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W06_06_JSON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\json";
        readonly string jsonPathExtension = "\\employees.json";

        public Employee CreateRandomEmployee(int id)
        {
            Employee employee = new Employee();
            employee.ID = id;
            employee.FirstName = FakeData.NameData.GetFirstName();
            employee.LastName = FakeData.NameData.GetSurname();
            employee.Phone = FakeData.PhoneNumberData.GetInternationalPhoneNumber();

            return employee;
        }

        public void CreateJSONDirectory()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private void buttonCreateJSON_Click(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>();

            for (int i = 1; i < 11; i++)
            {
                employees.Add(CreateRandomEmployee(i));
            }

            CreateJSONDirectory();

            string jsonEmployees = Newtonsoft.Json.JsonConvert.SerializeObject(employees);

            File.WriteAllText(path + jsonPathExtension, jsonEmployees);
        }

        private void buttonReadJSON_Click(object sender, EventArgs e)
        {
            string read = File.ReadAllText(path + jsonPathExtension);

            List<Employee> list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employee>>(read);

            listBox1.DataSource = list;
        }
    }
}