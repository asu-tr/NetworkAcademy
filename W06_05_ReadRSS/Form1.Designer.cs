namespace W06_05_ReadRSS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRSS = new System.Windows.Forms.Label();
            this.textBoxRSS = new System.Windows.Forms.TextBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.listBoxNews = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // labelRSS
            // 
            this.labelRSS.AutoSize = true;
            this.labelRSS.Location = new System.Drawing.Point(27, 28);
            this.labelRSS.Name = "labelRSS";
            this.labelRSS.Size = new System.Drawing.Size(65, 16);
            this.labelRSS.TabIndex = 0;
            this.labelRSS.Text = "RSS Link:";
            // 
            // textBoxRSS
            // 
            this.textBoxRSS.Location = new System.Drawing.Point(96, 25);
            this.textBoxRSS.Name = "textBoxRSS";
            this.textBoxRSS.Size = new System.Drawing.Size(270, 22);
            this.textBoxRSS.TabIndex = 1;
            this.textBoxRSS.Text = "https://www.cnnturk.com/feed/rss/all/news";
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(372, 25);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 2;
            this.buttonRead.Text = "READ";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // listBoxNews
            // 
            this.listBoxNews.FormattingEnabled = true;
            this.listBoxNews.ItemHeight = 16;
            this.listBoxNews.Location = new System.Drawing.Point(30, 73);
            this.listBoxNews.Name = "listBoxNews";
            this.listBoxNews.Size = new System.Drawing.Size(417, 324);
            this.listBoxNews.TabIndex = 3;
            this.listBoxNews.SelectedIndexChanged += new System.EventHandler(this.listBoxNews_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(473, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(446, 369);
            this.webBrowser1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 423);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.listBoxNews);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.textBoxRSS);
            this.Controls.Add(this.labelRSS);
            this.Name = "Form1";
            this.Text = "RSS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRSS;
        private System.Windows.Forms.TextBox textBoxRSS;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.ListBox listBoxNews;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

