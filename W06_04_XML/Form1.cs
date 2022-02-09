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
using System.Xml;
using System.Xml.Linq;

namespace W06_04_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        private void buttonCreateXML_Click(object sender, EventArgs e)
        {
            XmlTextWriter xmlText = new XmlTextWriter(path +"\\customers.xml", System.Text.UTF8Encoding.UTF8);

            xmlText.WriteComment("This is a comment.");

            xmlText.WriteStartElement("Customers");

            xmlText.WriteStartElement("Customer");
            xmlText.WriteAttributeString("ID", "1");
            xmlText.WriteElementString("Name", "Julia");
            xmlText.WriteEndElement();

            xmlText.WriteStartElement("Customer");
            xmlText.WriteAttributeString("ID", "2");
            xmlText.WriteElementString("Name", "Jonathan");
            xmlText.WriteEndElement();

            xmlText.WriteEndElement();

            xmlText.Close();
        }

        private void buttonReadXML_Click(object sender, EventArgs e)
        {
            XmlReader xmlReader = XmlReader.Create(path + "\\customers.xml");

            while (xmlReader.Read())
            {
                listBox.Items.Add(xmlReader.Name + " " + xmlReader.Value);
            }
        }

        private void buttonCreateXML_Linq_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < 51; i++)
            {
                Student student = new Student();
                student.Id = i+1;
                student.Name = FakeData.NameData.GetFullName();
                student.Address = FakeData.PlaceData.GetAddress();

                students.Add(student);
            }

            XDocument doc = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                new XElement(
                    "Students",
                    students.Select(
                        x => new XElement(
                            "Student",
                            new XElement("ID", x.Id.ToString()),
                            new XElement("Name", x.Name),
                            new XElement("Address", x.Address)
                            )
                        )
                    )
                );

            doc.Save(path+"\\students.xml");

            //{
            //    XDocument doc = new XDocument(
            //        new XDeclaration("1.0", "UTF-8", "yes"),
            //        new XElement("Students",
            //            new XComment("Comment line"),
            //            new XElement("Student",
            //                new XAttribute("ID", "1"),
            //                new XElement("Name", "Jackson"),
            //                new XElement("Address", "5-B")
            //                )
            //        )
            //    );
            //}
        }

        private void buttonReadXML_Linq_Click(object sender, EventArgs e)
        {
            XDocument xDoc = XDocument.Load(path + "\\students.xml");
            List<XElement> students;

            students = xDoc.Descendants("Student").ToList();

            //listBox2.DataSource = null;
            //listBox2.DataSource = students;

            foreach (var item in students)
            {
                listBox2.Items.Add(item.Element("ID").Value + " - " + item.Element("Name").Value + " - " + item.Element("Address").Value);
            }
        }
    }
}
