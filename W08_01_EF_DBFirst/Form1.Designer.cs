namespace W08_01_EF_DBFirst
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.radioBtnAsc = new System.Windows.Forms.RadioButton();
            this.radioBtnDes = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 96);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(488, 415);
            this.dgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxProductName.Location = new System.Drawing.Point(16, 49);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(100, 22);
            this.textBoxProductName.TabIndex = 2;
            // 
            // nud
            // 
            this.nud.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nud.Location = new System.Drawing.Point(135, 49);
            this.nud.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(98, 22);
            this.nud.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // cmbCat
            // 
            this.cmbCat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Location = new System.Drawing.Point(252, 47);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(121, 24);
            this.cmbCat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Category";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonUpdate.Location = new System.Drawing.Point(398, 48);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(102, 30);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonAdd.Location = new System.Drawing.Point(398, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 30);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // radioBtnAsc
            // 
            this.radioBtnAsc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioBtnAsc.AutoSize = true;
            this.radioBtnAsc.Checked = true;
            this.radioBtnAsc.Location = new System.Drawing.Point(94, 537);
            this.radioBtnAsc.Name = "radioBtnAsc";
            this.radioBtnAsc.Size = new System.Drawing.Size(126, 20);
            this.radioBtnAsc.TabIndex = 8;
            this.radioBtnAsc.TabStop = true;
            this.radioBtnAsc.Text = "Price Ascending";
            this.radioBtnAsc.UseVisualStyleBackColor = true;
            // 
            // radioBtnDes
            // 
            this.radioBtnDes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioBtnDes.AutoSize = true;
            this.radioBtnDes.Location = new System.Drawing.Point(277, 537);
            this.radioBtnDes.Name = "radioBtnDes";
            this.radioBtnDes.Size = new System.Drawing.Size(135, 20);
            this.radioBtnDes.TabIndex = 8;
            this.radioBtnDes.Text = "Price Descending";
            this.radioBtnDes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 582);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Search:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(199, 579);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(213, 22);
            this.textBoxSearch.TabIndex = 10;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 618);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioBtnDes);
            this.Controls.Add(this.radioBtnAsc);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RadioButton radioBtnAsc;
        private System.Windows.Forms.RadioButton radioBtnDes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}

