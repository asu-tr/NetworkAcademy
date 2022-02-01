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
        int rowcol = 0;
        int mineCount = 0;
        int mine = 0;
        string level = "";

        List<List<Button>> list = new List<List<Button>>();

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            level = "easy";
            curr_score = 0;
            rowcol = 4;
            mineCount = 0;
            labelCurrValue.Text = curr_score.ToString();

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Size = new Size(220, 250);

            list = new List<List<Button>>();

            for (int i = 0; i < rowcol; i++)
            {
                List<Button> tmp = new List<Button>();
                for (int j = 0; j < rowcol; j++)
                {
                    Button btn = new Button();
                    btn.Name = "btn" + i.ToString() +j.ToString();
                    btn.Size = new Size(40, 40);
                    btn.UseVisualStyleBackColor = true;
                    btn.ForeColor = Color.AntiqueWhite;

                    btn.Tag = Mine(60);

                    if ((bool)btn.Tag)
                        mineCount++;

                    flowLayoutPanel1.Controls.Add(btn);
                    btn.Click += btn_Click;
                    tmp.Add(btn);
                }
                list.Add(tmp);
            }
            labelMCValue.Text = mineCount.ToString();
        }

        private void buttonNormal_Click(object sender, EventArgs e)
        {
            level = "normal";
            curr_score = 0;
            rowcol = 5;
            mineCount = 0;
            labelCurrValue.Text = curr_score.ToString();

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Size = new Size(260, 260);

            list = new List<List<Button>>();

            for (int i = 0; i < rowcol; i++)
            {
                List<Button> tmp = new List<Button>();
                for (int j = 0; j < rowcol; j++)
                {
                    Button btn = new Button();
                    btn.Name = "btn" + i.ToString() + j.ToString();
                    btn.Size = new Size(40, 40);
                    btn.UseVisualStyleBackColor = true;
                    btn.ForeColor = Color.AntiqueWhite;

                    btn.Tag = Mine(50);

                    if ((bool)btn.Tag)
                        mineCount++;

                    flowLayoutPanel1.Controls.Add(btn);
                    btn.Click += btn_Click;
                    tmp.Add(btn);
                }
                list.Add(tmp);
            }

            labelMCValue.Text = mineCount.ToString();
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            level = "hard";
            curr_score = 0;
            rowcol = 7;
            labelCurrValue.Text = curr_score.ToString();

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Size = new Size(340, 340);

            list = new List<List<Button>>();

            for (int i = 0; i < rowcol; i++)
            {
                List<Button> tmp = new List<Button>();
                for (int j = 0; j < rowcol; j++)
                {
                    Button btn = new Button();
                    btn.Name = "btn" + i.ToString() + j.ToString();
                    btn.Size = new Size(40, 40);
                    btn.UseVisualStyleBackColor = true;
                    btn.ForeColor = Color.AntiqueWhite;

                    btn.Tag = Mine(40);

                    if ((bool)btn.Tag)
                        mineCount++;

                    flowLayoutPanel1.Controls.Add(btn);
                    btn.Click += btn_Click;
                    tmp.Add(btn);
                }
                list.Add(tmp);
            }
            labelMCValue.Text = mineCount.ToString();
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
                int row = Convert.ToInt32(pressed.Name.Substring(3, 1));
                int col = Convert.ToInt32(pressed.Name.Substring(4, 1));

                switch (level)
                {
                    case "easy":
                        mine = 0;

                        for (int i = row-1; i < row+2; i++)
                        {
                            for (int j = col-1; j < col+2; j++)
                            {
                                if (i >= 0 && j >= 0 && i <= 3 && j <= 3)
                                {
                                    Button b = (Button)list[i][j];
                                    bool ismine2 = (bool)b.Tag;

                                    if (ismine2)
                                    {
                                        mine++;
                                    }
                                }
                            }
                        }
                        pressed.Text = mine.ToString();
                        break;

                    case "normal":
                        mine = 0;

                        for (int i = row - 1; i < row + 2; i++)
                        {
                            for (int j = col - 1; j < col + 2; j++)
                            {
                                if (i >= 0 && j >= 0 && i <= 4 && j <= 4)
                                {
                                    Button b = (Button)list[i][j];
                                    bool ismine2 = (bool)b.Tag;

                                    if (ismine2)
                                    {
                                        mine++;
                                    }
                                }
                            }
                        }
                        pressed.Text = mine.ToString();
                        break;

                    case "hard":
                        mine = 0;

                        for (int i = row - 1; i < row + 2; i++)
                        {
                            for (int j = col - 1; j < col + 2; j++)
                            {
                                if (i >= 0 && j >= 0 && i <= 6 && j <= 6)
                                {
                                    Button b = (Button)list[i][j];
                                    bool ismine2 = (bool)b.Tag;

                                    if (ismine2)
                                    {
                                        mine++;
                                    }
                                }
                            }
                        }
                        pressed.Text = mine.ToString();
                        break;
                    default:
                        break;
                }

                pressed.BackColor = Color.DarkSlateBlue;
                curr_score++;
                labelCurrValue.Text = curr_score.ToString();

                int btnMine = 0;

                foreach (List<Button> btnlist in list)
                {
                    foreach (Button button in btnlist)
                    {
                        if (button.Text == "")
                            btnMine++;
                    }
                }

                if (btnMine == mineCount)
                {
                    MessageBox.Show("Congrats! You finished the game.");
                }
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
