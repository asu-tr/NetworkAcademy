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

namespace W06_01_FileFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            bool checkFolder = Directory.Exists("C:\\403");

            if (!checkFolder)
            {
                Directory.CreateDirectory("C:\\403");
                MessageBox.Show("Folder has been created.");
            }
            else
            {
                DialogResult result = MessageBox.Show("Folder already exists. Want to delete it and then create again?", "Folder Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Directory.Delete("C:\\403", true);
                    Directory.CreateDirectory("C:\\403");
                    MessageBox.Show("Folder deleted and a new one has been created.");
                }
                
            }
        }

        private void buttonMoveFolder_Click(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = Directory.CreateDirectory("C:\\500");
            directoryInfo.MoveTo("C:\\501");

            // Directory.Move("C:\\403", "C:\\deneme");
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
           FileStream fs = File.Create("C:\\403\\sth.txt");
            fs.Close();
            bool fileExist = File.Exists("C:\\403\\sth.txt");

            if (fileExist)
            {
                File.AppendAllText("C:\\403\\sth.txt", "Hello World");
            }
        }

        private void buttonCopyFile_Click(object sender, EventArgs e)
        {
            File.Copy("C:\\403\\sth.txt", "C:\\403\\sth2.txt");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            File.Delete("C:\\403\\sth2.txt");
        }

    }
}
