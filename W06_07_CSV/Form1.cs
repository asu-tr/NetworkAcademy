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

namespace W06_07_CSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\csv";
        readonly string csvPathExtension = "\\employers.csv";

        public List<Employer> CreateRandomEmployer(int count)
        {
            List<Employer> temp = new List<Employer>();

            for (int i = 0; i < count; i++)
            {
                Employer employer = new Employer();
                employer.ID = i;
                employer.FirstName = FakeData.NameData.GetFirstName();
                employer.LastName = FakeData.NameData.GetSurname();
                employer.Phone = FakeData.PhoneNumberData.GetInternationalPhoneNumber();
                temp.Add(employer);
            }

            return temp;
        }

        public void CreateCSVDirectory()
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private void buttonCreateCSV_Click(object sender, EventArgs e)
        {
            List<Employer> employers = CreateRandomEmployer(10);

            CreateCSVDirectory();

            StreamWriter file = new StreamWriter(path+csvPathExtension);

            CsvHelper.CsvWriter csv = new CsvHelper.CsvWriter(file);

            csv.WriteHeader(typeof(Employer));

            csv.WriteRecords(employers);

            file.Close();
        }

        private void buttonReadCSV_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(path + csvPathExtension);
            CsvHelper.CsvReader read = new CsvHelper.CsvReader(sr);

            List<Employer> employers = read.GetRecords<Employer>().ToList();
            listBox1.DataSource = employers;
        }
    }
}