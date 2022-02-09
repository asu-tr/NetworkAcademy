namespace W06_07_CSV
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
            this.buttonCreateCSV = new System.Windows.Forms.Button();
            this.buttonReadCSV = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCreateCSV
            // 
            this.buttonCreateCSV.Location = new System.Drawing.Point(44, 37);
            this.buttonCreateCSV.Name = "buttonCreateCSV";
            this.buttonCreateCSV.Size = new System.Drawing.Size(131, 49);
            this.buttonCreateCSV.TabIndex = 0;
            this.buttonCreateCSV.Text = "Create CSV";
            this.buttonCreateCSV.UseVisualStyleBackColor = true;
            this.buttonCreateCSV.Click += new System.EventHandler(this.buttonCreateCSV_Click);
            // 
            // buttonReadCSV
            // 
            this.buttonReadCSV.Location = new System.Drawing.Point(44, 113);
            this.buttonReadCSV.Name = "buttonReadCSV";
            this.buttonReadCSV.Size = new System.Drawing.Size(131, 49);
            this.buttonReadCSV.TabIndex = 0;
            this.buttonReadCSV.Text = "Read CSV";
            this.buttonReadCSV.UseVisualStyleBackColor = true;
            this.buttonReadCSV.Click += new System.EventHandler(this.buttonReadCSV_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(44, 192);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(131, 228);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 459);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonReadCSV);
            this.Controls.Add(this.buttonCreateCSV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateCSV;
        private System.Windows.Forms.Button buttonReadCSV;
        private System.Windows.Forms.ListBox listBox1;
    }
}

