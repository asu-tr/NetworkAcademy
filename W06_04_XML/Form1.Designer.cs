namespace W06_04_XML
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
            this.buttonCreateXML = new System.Windows.Forms.Button();
            this.buttonReadXML = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonReadXML_Linq = new System.Windows.Forms.Button();
            this.buttonCreateXML_Linq = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateXML
            // 
            this.buttonCreateXML.Location = new System.Drawing.Point(25, 24);
            this.buttonCreateXML.Name = "buttonCreateXML";
            this.buttonCreateXML.Size = new System.Drawing.Size(159, 48);
            this.buttonCreateXML.TabIndex = 0;
            this.buttonCreateXML.Text = "Create XML File";
            this.buttonCreateXML.UseVisualStyleBackColor = true;
            this.buttonCreateXML.Click += new System.EventHandler(this.buttonCreateXML_Click);
            // 
            // buttonReadXML
            // 
            this.buttonReadXML.Location = new System.Drawing.Point(25, 85);
            this.buttonReadXML.Name = "buttonReadXML";
            this.buttonReadXML.Size = new System.Drawing.Size(159, 48);
            this.buttonReadXML.TabIndex = 1;
            this.buttonReadXML.Text = "Read XML File";
            this.buttonReadXML.UseVisualStyleBackColor = true;
            this.buttonReadXML.Click += new System.EventHandler(this.buttonReadXML_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(25, 149);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(159, 244);
            this.listBox.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCreateXML);
            this.splitContainer1.Panel1.Controls.Add(this.buttonReadXML);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label);
            this.splitContainer1.Panel2.Controls.Add(this.listBox2);
            this.splitContainer1.Panel2.Controls.Add(this.buttonReadXML_Linq);
            this.splitContainer1.Panel2.Controls.Add(this.buttonCreateXML_Linq);
            this.splitContainer1.Size = new System.Drawing.Size(575, 411);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.TabIndex = 3;
            // 
            // buttonReadXML_Linq
            // 
            this.buttonReadXML_Linq.Location = new System.Drawing.Point(15, 97);
            this.buttonReadXML_Linq.Name = "buttonReadXML_Linq";
            this.buttonReadXML_Linq.Size = new System.Drawing.Size(248, 48);
            this.buttonReadXML_Linq.TabIndex = 2;
            this.buttonReadXML_Linq.Text = "Read XML File with LINQ";
            this.buttonReadXML_Linq.UseVisualStyleBackColor = true;
            this.buttonReadXML_Linq.Click += new System.EventHandler(this.buttonReadXML_Linq_Click);
            // 
            // buttonCreateXML_Linq
            // 
            this.buttonCreateXML_Linq.Location = new System.Drawing.Point(15, 36);
            this.buttonCreateXML_Linq.Name = "buttonCreateXML_Linq";
            this.buttonCreateXML_Linq.Size = new System.Drawing.Size(248, 48);
            this.buttonCreateXML_Linq.TabIndex = 0;
            this.buttonCreateXML_Linq.Text = "Create XML File with LINQ";
            this.buttonCreateXML_Linq.UseVisualStyleBackColor = true;
            this.buttonCreateXML_Linq.Click += new System.EventHandler(this.buttonCreateXML_Linq_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(15, 161);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(248, 244);
            this.listBox2.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(83, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(96, 16);
            this.label.TabIndex = 4;
            this.label.Text = "With FakeData";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 438);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateXML;
        private System.Windows.Forms.Button buttonReadXML;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonReadXML_Linq;
        private System.Windows.Forms.Button buttonCreateXML_Linq;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label;
    }
}

