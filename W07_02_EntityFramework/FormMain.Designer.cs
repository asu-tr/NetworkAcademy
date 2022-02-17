namespace W07_02_EntityFramework
{
    partial class FormMain
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
            this.labelPN = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.labelStock = new System.Windows.Forms.Label();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.labelCat = new System.Windows.Forms.Label();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.comboCat = new System.Windows.Forms.ComboBox();
            this.comboSup = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 58);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1050, 452);
            this.dgv.TabIndex = 13;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // labelPN
            // 
            this.labelPN.AutoSize = true;
            this.labelPN.Location = new System.Drawing.Point(24, 9);
            this.labelPN.Name = "labelPN";
            this.labelPN.Size = new System.Drawing.Size(96, 16);
            this.labelPN.TabIndex = 0;
            this.labelPN.Text = "Product Name:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(27, 28);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(100, 22);
            this.textBoxProductName.TabIndex = 1;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(181, 9);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(41, 16);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Price:";
            // 
            // nudPrice
            // 
            this.nudPrice.Location = new System.Drawing.Point(184, 28);
            this.nudPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(64, 22);
            this.nudPrice.TabIndex = 3;
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(301, 9);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(44, 16);
            this.labelStock.TabIndex = 4;
            this.labelStock.Text = "Stock:";
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(304, 28);
            this.nudStock.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(64, 22);
            this.nudStock.TabIndex = 5;
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Location = new System.Drawing.Point(426, 9);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(65, 16);
            this.labelCat.TabIndex = 6;
            this.labelCat.Text = "Category:";
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Location = new System.Drawing.Point(612, 9);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(60, 16);
            this.labelSupplier.TabIndex = 8;
            this.labelSupplier.Text = "Supplier:";
            // 
            // comboCat
            // 
            this.comboCat.FormattingEnabled = true;
            this.comboCat.Location = new System.Drawing.Point(429, 28);
            this.comboCat.Name = "comboCat";
            this.comboCat.Size = new System.Drawing.Size(121, 24);
            this.comboCat.TabIndex = 7;
            // 
            // comboSup
            // 
            this.comboSup.FormattingEnabled = true;
            this.comboSup.Location = new System.Drawing.Point(615, 28);
            this.comboSup.Name = "comboSup";
            this.comboSup.Size = new System.Drawing.Size(121, 24);
            this.comboSup.TabIndex = 9;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(772, 7);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 43);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(876, 7);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 43);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(973, 7);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 43);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(12, 519);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(160, 16);
            this.labelSearch.TabIndex = 14;
            this.labelSearch.Text = "Search by Product Name:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(184, 516);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(214, 22);
            this.textBoxSearch.TabIndex = 15;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 546);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboSup);
            this.Controls.Add(this.comboCat);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.labelCat);
            this.Controls.Add(this.nudStock);
            this.Controls.Add(this.nudPrice);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.labelPN);
            this.Controls.Add(this.dgv);
            this.Name = "FormMain";
            this.Text = "Northwind";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label labelPN;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.ComboBox comboCat;
        private System.Windows.Forms.ComboBox comboSup;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
    }
}

