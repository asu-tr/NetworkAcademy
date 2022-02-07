namespace W06_02_Example
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
            this.listBoxPeople = new System.Windows.Forms.ListBox();
            this.buttonGetPerson = new System.Windows.Forms.Button();
            this.buttonCountryFolder = new System.Windows.Forms.Button();
            this.buttonPersonFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPeople
            // 
            this.listBoxPeople.FormattingEnabled = true;
            this.listBoxPeople.ItemHeight = 16;
            this.listBoxPeople.Location = new System.Drawing.Point(61, 41);
            this.listBoxPeople.Name = "listBoxPeople";
            this.listBoxPeople.Size = new System.Drawing.Size(156, 244);
            this.listBoxPeople.TabIndex = 0;
            // 
            // buttonGetPerson
            // 
            this.buttonGetPerson.Location = new System.Drawing.Point(61, 300);
            this.buttonGetPerson.Name = "buttonGetPerson";
            this.buttonGetPerson.Size = new System.Drawing.Size(156, 23);
            this.buttonGetPerson.TabIndex = 1;
            this.buttonGetPerson.Text = "Get Person";
            this.buttonGetPerson.UseVisualStyleBackColor = true;
            this.buttonGetPerson.Click += new System.EventHandler(this.buttonGetPerson_Click);
            // 
            // buttonCountryFolder
            // 
            this.buttonCountryFolder.Location = new System.Drawing.Point(61, 339);
            this.buttonCountryFolder.Name = "buttonCountryFolder";
            this.buttonCountryFolder.Size = new System.Drawing.Size(156, 23);
            this.buttonCountryFolder.TabIndex = 2;
            this.buttonCountryFolder.Text = "Create Country Folder";
            this.buttonCountryFolder.UseVisualStyleBackColor = true;
            this.buttonCountryFolder.Click += new System.EventHandler(this.buttonCountryFolder_Click);
            // 
            // buttonPersonFile
            // 
            this.buttonPersonFile.Location = new System.Drawing.Point(62, 381);
            this.buttonPersonFile.Name = "buttonPersonFile";
            this.buttonPersonFile.Size = new System.Drawing.Size(155, 23);
            this.buttonPersonFile.TabIndex = 3;
            this.buttonPersonFile.Text = "Create Person Files";
            this.buttonPersonFile.UseVisualStyleBackColor = true;
            this.buttonPersonFile.Click += new System.EventHandler(this.buttonPersonFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 454);
            this.Controls.Add(this.buttonPersonFile);
            this.Controls.Add(this.buttonCountryFolder);
            this.Controls.Add(this.buttonGetPerson);
            this.Controls.Add(this.listBoxPeople);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPeople;
        private System.Windows.Forms.Button buttonGetPerson;
        private System.Windows.Forms.Button buttonCountryFolder;
        private System.Windows.Forms.Button buttonPersonFile;
    }
}

