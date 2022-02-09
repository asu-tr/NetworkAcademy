using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace W06_05_ReadRSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            ReadXML();
        }

        private void ReadXML()
        {
            XDocument resource = XDocument.Load(textBoxRSS.Text);

            List<XElement> list = resource.Descendants("item").ToList();

            List<News> newsList = new List<News>();

            foreach (var item in list)
            {
                News news = new News();

                news.Title = item.Element("title").Value;
                news.Link = item.Element("link").Value;
                news.Description = item.Element("description").Value;

                newsList.Add(news);
            }

            listBoxNews.DataSource = newsList;
        }

        private void listBoxNews_SelectedIndexChanged(object sender, EventArgs e)
        {
            News news = (News)listBoxNews.SelectedItem;

            webBrowser1.DocumentText = news.Description;
        }
    }
}
