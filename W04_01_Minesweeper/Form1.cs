using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W04_01_Minesweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int highscore = 0;
        int curr_score = 0;

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            curr_score = 0;
            labelCurrValue.Text = curr_score.ToString();

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Size = new Size(220, 250);
            for (int i = 0; i < 16; i++)
            {
                Button btn = new Button();
                btn.Name = "btn" + i;
                btn.Size = new Size(40, 40);
                btn.Text = (i+1).ToString();
                btn.UseVisualStyleBackColor = true;

                if (Mine(60))
                    btn.Tag = true;
                else
                    btn.Tag = false;

                flowLayoutPanel1.Controls.Add(btn);
                btn.Click += btn_Click;
            }
        }

        private void buttonNormal_Click(object sender, EventArgs e)
        {
            curr_score = 0;
            labelCurrValue.Text = curr_score.ToString();

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Size = new Size(260, 260);
            for (int i = 0; i < 25; i++)
            {
                Button btn = new Button();
                btn.Name = "btn" + i;
                btn.Size = new Size(40, 40);
                btn.Text = (i + 1).ToString();
                btn.UseVisualStyleBackColor = true;
                btn.Click += btn_Click;

                if (Mine(50))
                    btn.Tag = true;
                else
                    btn.Tag = false;

                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            curr_score = 0;
            labelCurrValue.Text = curr_score.ToString();

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Size = new Size(340, 340);
            for (int i = 0; i < 49; i++)
            {
                Button btn = new Button();
                btn.Name = "btn" + i;
                btn.Size = new Size(40, 40);
                btn.Text = (i + 1).ToString();
                btn.UseVisualStyleBackColor = true;
                btn.Click += btn_Click;

                if (Mine(40))
                    btn.Tag = true;
                else
                    btn.Tag = false;

                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button pressed =(Button)sender;
            bool ismine = (bool)pressed.Tag;

            if (ismine)
            {
                pressed.BackColor = Color.DarkRed;
                if (highscore < curr_score)
                {
                    MessageBox.Show("New Highscore!");
                    highscore = curr_score;
                    labelHSValue.Text = highscore.ToString();
                }
                else
                {
                    MessageBox.Show("Failed!");
                    flowLayoutPanel1.Controls.Clear();
                }
            }
            else
            {
                pressed.BackColor = Color.DarkSlateBlue;
                curr_score++;
                labelCurrValue.Text = curr_score.ToString();
            }
        }

        private bool Mine(int num)
        {
            Thread.Sleep(10);
            Random rnd = new Random();
            int i = rnd.Next(1, num);
            if (i <= 10)
                return true;
            else
                return false;
        }
    }
}
