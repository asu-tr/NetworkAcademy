namespace W03_21_GroupBox
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelFN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // labelFN
            // 
            this.labelFN.AutoSize = true;
            this.labelFN.Location = new System.Drawing.Point(209, 47);
            this.labelFN.Name = "labelFN";
            this.labelFN.Size = new System.Drawing.Size(0, 16);
            this.labelFN.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name:";
            // 
            // labelLN
            // 
            this.labelLN.AutoSize = true;
            this.labelLN.Location = new System.Drawing.Point(209, 94);
            this.labelLN.Name = "labelLN";
            this.labelLN.Size = new System.Drawing.Size(0, 16);
            this.labelLN.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone:";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(209, 143);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(0, 16);
            this.labelP.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Email:";
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Location = new System.Drawing.Point(209, 195);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(0, 16);
            this.labelE.TabIndex = 1;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(71, 262);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(252, 55);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 383);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelLN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelFN);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Button buttonOK;
    }
}