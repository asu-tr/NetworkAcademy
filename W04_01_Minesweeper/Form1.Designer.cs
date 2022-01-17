namespace W04_01_Minesweeper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonEasy = new System.Windows.Forms.Button();
            this.buttonNormal = new System.Windows.Forms.Button();
            this.buttonHard = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelHS = new System.Windows.Forms.Label();
            this.labelHSValue = new System.Windows.Forms.Label();
            this.labelCurr = new System.Windows.Forms.Label();
            this.labelCurrValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEasy
            // 
            this.buttonEasy.Location = new System.Drawing.Point(12, 12);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(116, 48);
            this.buttonEasy.TabIndex = 0;
            this.buttonEasy.Text = "EASY";
            this.buttonEasy.UseVisualStyleBackColor = true;
            this.buttonEasy.Click += new System.EventHandler(this.buttonEasy_Click);
            // 
            // buttonNormal
            // 
            this.buttonNormal.Location = new System.Drawing.Point(134, 12);
            this.buttonNormal.Name = "buttonNormal";
            this.buttonNormal.Size = new System.Drawing.Size(116, 48);
            this.buttonNormal.TabIndex = 0;
            this.buttonNormal.Text = "NORMAL";
            this.buttonNormal.UseVisualStyleBackColor = true;
            this.buttonNormal.Click += new System.EventHandler(this.buttonNormal_Click);
            // 
            // buttonHard
            // 
            this.buttonHard.Location = new System.Drawing.Point(256, 12);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(116, 48);
            this.buttonHard.TabIndex = 0;
            this.buttonHard.Text = "HARD";
            this.buttonHard.UseVisualStyleBackColor = true;
            this.buttonHard.Click += new System.EventHandler(this.buttonHard_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(480, 424);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // labelHS
            // 
            this.labelHS.AutoSize = true;
            this.labelHS.Location = new System.Drawing.Point(378, 18);
            this.labelHS.Name = "labelHS";
            this.labelHS.Size = new System.Drawing.Size(95, 16);
            this.labelHS.TabIndex = 2;
            this.labelHS.Text = "Highest Score:";
            // 
            // labelHSValue
            // 
            this.labelHSValue.AutoSize = true;
            this.labelHSValue.Location = new System.Drawing.Point(475, 18);
            this.labelHSValue.Name = "labelHSValue";
            this.labelHSValue.Size = new System.Drawing.Size(14, 16);
            this.labelHSValue.TabIndex = 3;
            this.labelHSValue.Text = "0";
            // 
            // labelCurr
            // 
            this.labelCurr.AutoSize = true;
            this.labelCurr.Location = new System.Drawing.Point(378, 41);
            this.labelCurr.Name = "labelCurr";
            this.labelCurr.Size = new System.Drawing.Size(91, 16);
            this.labelCurr.TabIndex = 2;
            this.labelCurr.Text = "Current Score:";
            // 
            // labelCurrValue
            // 
            this.labelCurrValue.AutoSize = true;
            this.labelCurrValue.Location = new System.Drawing.Point(475, 41);
            this.labelCurrValue.Name = "labelCurrValue";
            this.labelCurrValue.Size = new System.Drawing.Size(14, 16);
            this.labelCurrValue.TabIndex = 3;
            this.labelCurrValue.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 513);
            this.Controls.Add(this.labelCurrValue);
            this.Controls.Add(this.labelHSValue);
            this.Controls.Add(this.labelCurr);
            this.Controls.Add(this.labelHS);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonHard);
            this.Controls.Add(this.buttonNormal);
            this.Controls.Add(this.buttonEasy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Minesweeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEasy;
        private System.Windows.Forms.Button buttonNormal;
        private System.Windows.Forms.Button buttonHard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelHS;
        private System.Windows.Forms.Label labelHSValue;
        private System.Windows.Forms.Label labelCurr;
        private System.Windows.Forms.Label labelCurrValue;
    }
}

