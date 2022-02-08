namespace W06_03_LINQ
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
            this.listBoxFound = new System.Windows.Forms.ListBox();
            this.buttonGet100 = new System.Windows.Forms.Button();
            this.buttonFN_A_LINQ = new System.Windows.Forms.Button();
            this.buttonFN_A_LINQ_ToQuery = new System.Windows.Forms.Button();
            this.buttonBD_FN = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonAge18 = new System.Windows.Forms.Button();
            this.buttonFN_LN_BD = new System.Windows.Forms.Button();
            this.buttonFE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxFound
            // 
            this.listBoxFound.FormattingEnabled = true;
            this.listBoxFound.ItemHeight = 16;
            this.listBoxFound.Location = new System.Drawing.Point(13, 13);
            this.listBoxFound.Name = "listBoxFound";
            this.listBoxFound.Size = new System.Drawing.Size(367, 404);
            this.listBoxFound.TabIndex = 0;
            // 
            // buttonGet100
            // 
            this.buttonGet100.Location = new System.Drawing.Point(386, 15);
            this.buttonGet100.Name = "buttonGet100";
            this.buttonGet100.Size = new System.Drawing.Size(170, 45);
            this.buttonGet100.TabIndex = 1;
            this.buttonGet100.Text = "Get 100 Customers";
            this.buttonGet100.UseVisualStyleBackColor = true;
            this.buttonGet100.Click += new System.EventHandler(this.buttonGet100_Click);
            // 
            // buttonFN_A_LINQ
            // 
            this.buttonFN_A_LINQ.Location = new System.Drawing.Point(386, 66);
            this.buttonFN_A_LINQ.Name = "buttonFN_A_LINQ";
            this.buttonFN_A_LINQ.Size = new System.Drawing.Size(170, 45);
            this.buttonFN_A_LINQ.TabIndex = 1;
            this.buttonFN_A_LINQ.Text = "Name Starting with A - LINQ";
            this.buttonFN_A_LINQ.UseVisualStyleBackColor = true;
            this.buttonFN_A_LINQ.Click += new System.EventHandler(this.buttonFN_A_LINQ_Click);
            // 
            // buttonFN_A_LINQ_ToQuery
            // 
            this.buttonFN_A_LINQ_ToQuery.Location = new System.Drawing.Point(386, 117);
            this.buttonFN_A_LINQ_ToQuery.Name = "buttonFN_A_LINQ_ToQuery";
            this.buttonFN_A_LINQ_ToQuery.Size = new System.Drawing.Size(170, 45);
            this.buttonFN_A_LINQ_ToQuery.TabIndex = 1;
            this.buttonFN_A_LINQ_ToQuery.Text = "Name Starting with A - LINQ to Query";
            this.buttonFN_A_LINQ_ToQuery.UseVisualStyleBackColor = true;
            this.buttonFN_A_LINQ_ToQuery.Click += new System.EventHandler(this.buttonFN_A_LINQ_ToQuery_Click);
            // 
            // buttonBD_FN
            // 
            this.buttonBD_FN.Location = new System.Drawing.Point(386, 168);
            this.buttonBD_FN.Name = "buttonBD_FN";
            this.buttonBD_FN.Size = new System.Drawing.Size(170, 45);
            this.buttonBD_FN.TabIndex = 1;
            this.buttonBD_FN.Text = "BirthDate > 2010, FirstName contains A";
            this.buttonBD_FN.UseVisualStyleBackColor = true;
            this.buttonBD_FN.Click += new System.EventHandler(this.buttonBD_FN_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(386, 219);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(170, 45);
            this.buttonHistory.TabIndex = 1;
            this.buttonHistory.Text = "// See codes, history...";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonAge18
            // 
            this.buttonAge18.Location = new System.Drawing.Point(386, 270);
            this.buttonAge18.Name = "buttonAge18";
            this.buttonAge18.Size = new System.Drawing.Size(170, 45);
            this.buttonAge18.TabIndex = 1;
            this.buttonAge18.Text = "Age +18";
            this.buttonAge18.UseVisualStyleBackColor = true;
            this.buttonAge18.Click += new System.EventHandler(this.buttonAge18_Click);
            // 
            // buttonFN_LN_BD
            // 
            this.buttonFN_LN_BD.Location = new System.Drawing.Point(386, 321);
            this.buttonFN_LN_BD.Name = "buttonFN_LN_BD";
            this.buttonFN_LN_BD.Size = new System.Drawing.Size(170, 45);
            this.buttonFN_LN_BD.TabIndex = 1;
            this.buttonFN_LN_BD.Text = "FN Start B OR LN Cont. E, BD > 2000";
            this.buttonFN_LN_BD.UseVisualStyleBackColor = true;
            this.buttonFN_LN_BD.Click += new System.EventHandler(this.buttonFN_LN_BD_Click);
            // 
            // buttonFE
            // 
            this.buttonFE.Location = new System.Drawing.Point(386, 372);
            this.buttonFE.Name = "buttonFE";
            this.buttonFE.Size = new System.Drawing.Size(170, 45);
            this.buttonFE.TabIndex = 1;
            this.buttonFE.Text = "Add With ForEach";
            this.buttonFE.UseVisualStyleBackColor = true;
            this.buttonFE.Click += new System.EventHandler(this.buttonFE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.buttonFE);
            this.Controls.Add(this.buttonFN_LN_BD);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonAge18);
            this.Controls.Add(this.buttonBD_FN);
            this.Controls.Add(this.buttonFN_A_LINQ_ToQuery);
            this.Controls.Add(this.buttonFN_A_LINQ);
            this.Controls.Add(this.buttonGet100);
            this.Controls.Add(this.listBoxFound);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFound;
        private System.Windows.Forms.Button buttonGet100;
        private System.Windows.Forms.Button buttonFN_A_LINQ;
        private System.Windows.Forms.Button buttonFN_A_LINQ_ToQuery;
        private System.Windows.Forms.Button buttonBD_FN;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonAge18;
        private System.Windows.Forms.Button buttonFN_LN_BD;
        private System.Windows.Forms.Button buttonFE;
    }
}

