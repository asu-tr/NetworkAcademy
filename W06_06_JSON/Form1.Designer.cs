namespace W06_06_JSON
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
            this.buttonCreateJSON = new System.Windows.Forms.Button();
            this.buttonReadJSON = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonCreateJSON
            // 
            this.buttonCreateJSON.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateJSON.Name = "buttonCreateJSON";
            this.buttonCreateJSON.Size = new System.Drawing.Size(191, 59);
            this.buttonCreateJSON.TabIndex = 0;
            this.buttonCreateJSON.Text = "Create JSON File";
            this.buttonCreateJSON.UseVisualStyleBackColor = true;
            this.buttonCreateJSON.Click += new System.EventHandler(this.buttonCreateJSON_Click);
            // 
            // buttonReadJSON
            // 
            this.buttonReadJSON.Location = new System.Drawing.Point(12, 89);
            this.buttonReadJSON.Name = "buttonReadJSON";
            this.buttonReadJSON.Size = new System.Drawing.Size(191, 59);
            this.buttonReadJSON.TabIndex = 1;
            this.buttonReadJSON.Text = "Read JSON File";
            this.buttonReadJSON.UseVisualStyleBackColor = true;
            this.buttonReadJSON.Click += new System.EventHandler(this.buttonReadJSON_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 169);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 260);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 442);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonReadJSON);
            this.Controls.Add(this.buttonCreateJSON);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateJSON;
        private System.Windows.Forms.Button buttonReadJSON;
        private System.Windows.Forms.ListBox listBox1;
    }
}

