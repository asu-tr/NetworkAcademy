namespace W04_02_Automation
{
    partial class FormPizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPizza));
            this.labelSize = new System.Windows.Forms.Label();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.labelPizza = new System.Windows.Forms.Label();
            this.listBoxPizza = new System.Windows.Forms.ListBox();
            this.radioButtonClassic = new System.Windows.Forms.RadioButton();
            this.radioButtonCheesy = new System.Windows.Forms.RadioButton();
            this.label = new System.Windows.Forms.Label();
            this.groupBoxIng = new System.Windows.Forms.GroupBox();
            this.checkBoxIS = new System.Windows.Forms.CheckBox();
            this.checkBoxMO = new System.Windows.Forms.CheckBox();
            this.checkBoxOL = new System.Windows.Forms.CheckBox();
            this.checkBoxPI = new System.Windows.Forms.CheckBox();
            this.checkBoxCT = new System.Windows.Forms.CheckBox();
            this.checkBoxMU = new System.Windows.Forms.CheckBox();
            this.checkBoxJA = new System.Windows.Forms.CheckBox();
            this.checkBoxSC = new System.Windows.Forms.CheckBox();
            this.listBoxBasket = new System.Windows.Forms.ListBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalValue = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelOrders = new System.Windows.Forms.Label();
            this.richTextBoxOrders = new System.Windows.Forms.RichTextBox();
            this.groupBoxIng.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(27, 72);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(36, 16);
            this.labelSize.TabIndex = 1;
            this.labelSize.Text = "Size:";
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(69, 69);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(220, 24);
            this.comboBoxSize.TabIndex = 2;
            // 
            // labelPizza
            // 
            this.labelPizza.AutoSize = true;
            this.labelPizza.Location = new System.Drawing.Point(27, 113);
            this.labelPizza.Name = "labelPizza";
            this.labelPizza.Size = new System.Drawing.Size(46, 16);
            this.labelPizza.TabIndex = 3;
            this.labelPizza.Text = "Pizzas";
            // 
            // listBoxPizza
            // 
            this.listBoxPizza.FormattingEnabled = true;
            this.listBoxPizza.ItemHeight = 16;
            this.listBoxPizza.Location = new System.Drawing.Point(30, 132);
            this.listBoxPizza.Name = "listBoxPizza";
            this.listBoxPizza.Size = new System.Drawing.Size(259, 148);
            this.listBoxPizza.TabIndex = 4;
            // 
            // radioButtonClassic
            // 
            this.radioButtonClassic.AutoSize = true;
            this.radioButtonClassic.Location = new System.Drawing.Point(333, 74);
            this.radioButtonClassic.Name = "radioButtonClassic";
            this.radioButtonClassic.Size = new System.Drawing.Size(105, 20);
            this.radioButtonClassic.TabIndex = 5;
            this.radioButtonClassic.TabStop = true;
            this.radioButtonClassic.Text = "Classic Crust";
            this.radioButtonClassic.UseVisualStyleBackColor = true;
            // 
            // radioButtonCheesy
            // 
            this.radioButtonCheesy.AutoSize = true;
            this.radioButtonCheesy.Location = new System.Drawing.Point(456, 74);
            this.radioButtonCheesy.Name = "radioButtonCheesy";
            this.radioButtonCheesy.Size = new System.Drawing.Size(149, 20);
            this.radioButtonCheesy.TabIndex = 6;
            this.radioButtonCheesy.TabStop = true;
            this.radioButtonCheesy.Text = "Cheesy Crust (+$3.5)";
            this.radioButtonCheesy.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(371, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(129, 50);
            this.label.TabIndex = 0;
            this.label.Text = "PIZZASU";
            // 
            // groupBoxIng
            // 
            this.groupBoxIng.Controls.Add(this.checkBoxIS);
            this.groupBoxIng.Controls.Add(this.checkBoxMO);
            this.groupBoxIng.Controls.Add(this.checkBoxOL);
            this.groupBoxIng.Controls.Add(this.checkBoxPI);
            this.groupBoxIng.Controls.Add(this.checkBoxCT);
            this.groupBoxIng.Controls.Add(this.checkBoxMU);
            this.groupBoxIng.Controls.Add(this.checkBoxJA);
            this.groupBoxIng.Controls.Add(this.checkBoxSC);
            this.groupBoxIng.Location = new System.Drawing.Point(317, 122);
            this.groupBoxIng.Name = "groupBoxIng";
            this.groupBoxIng.Size = new System.Drawing.Size(288, 189);
            this.groupBoxIng.TabIndex = 7;
            this.groupBoxIng.TabStop = false;
            this.groupBoxIng.Text = "Extra Ingredients (+$1.2)";
            // 
            // checkBoxIS
            // 
            this.checkBoxIS.AutoSize = true;
            this.checkBoxIS.Location = new System.Drawing.Point(159, 146);
            this.checkBoxIS.Name = "checkBoxIS";
            this.checkBoxIS.Size = new System.Drawing.Size(122, 20);
            this.checkBoxIS.TabIndex = 7;
            this.checkBoxIS.Text = "Italian Sausage";
            this.checkBoxIS.UseVisualStyleBackColor = true;
            // 
            // checkBoxMO
            // 
            this.checkBoxMO.AutoSize = true;
            this.checkBoxMO.Location = new System.Drawing.Point(16, 146);
            this.checkBoxMO.Name = "checkBoxMO";
            this.checkBoxMO.Size = new System.Drawing.Size(144, 20);
            this.checkBoxMO.TabIndex = 6;
            this.checkBoxMO.Text = "Mozzarella Cheese";
            this.checkBoxMO.UseVisualStyleBackColor = true;
            // 
            // checkBoxOL
            // 
            this.checkBoxOL.AutoSize = true;
            this.checkBoxOL.Location = new System.Drawing.Point(159, 112);
            this.checkBoxOL.Name = "checkBoxOL";
            this.checkBoxOL.Size = new System.Drawing.Size(67, 20);
            this.checkBoxOL.TabIndex = 5;
            this.checkBoxOL.Text = "Olives";
            this.checkBoxOL.UseVisualStyleBackColor = true;
            // 
            // checkBoxPI
            // 
            this.checkBoxPI.AutoSize = true;
            this.checkBoxPI.Location = new System.Drawing.Point(16, 112);
            this.checkBoxPI.Name = "checkBoxPI";
            this.checkBoxPI.Size = new System.Drawing.Size(91, 20);
            this.checkBoxPI.TabIndex = 4;
            this.checkBoxPI.Text = "Pineapple";
            this.checkBoxPI.UseVisualStyleBackColor = true;
            // 
            // checkBoxCT
            // 
            this.checkBoxCT.AutoSize = true;
            this.checkBoxCT.Location = new System.Drawing.Point(159, 74);
            this.checkBoxCT.Name = "checkBoxCT";
            this.checkBoxCT.Size = new System.Drawing.Size(118, 20);
            this.checkBoxCT.TabIndex = 3;
            this.checkBoxCT.Text = "Cherry Tomato";
            this.checkBoxCT.UseVisualStyleBackColor = true;
            // 
            // checkBoxMU
            // 
            this.checkBoxMU.AutoSize = true;
            this.checkBoxMU.Location = new System.Drawing.Point(16, 74);
            this.checkBoxMU.Name = "checkBoxMU";
            this.checkBoxMU.Size = new System.Drawing.Size(92, 20);
            this.checkBoxMU.TabIndex = 2;
            this.checkBoxMU.Text = "Mushroom";
            this.checkBoxMU.UseVisualStyleBackColor = true;
            // 
            // checkBoxJA
            // 
            this.checkBoxJA.AutoSize = true;
            this.checkBoxJA.Location = new System.Drawing.Point(159, 36);
            this.checkBoxJA.Name = "checkBoxJA";
            this.checkBoxJA.Size = new System.Drawing.Size(93, 20);
            this.checkBoxJA.TabIndex = 1;
            this.checkBoxJA.Text = "Jalapenos";
            this.checkBoxJA.UseVisualStyleBackColor = true;
            // 
            // checkBoxSC
            // 
            this.checkBoxSC.AutoSize = true;
            this.checkBoxSC.Location = new System.Drawing.Point(16, 36);
            this.checkBoxSC.Name = "checkBoxSC";
            this.checkBoxSC.Size = new System.Drawing.Size(143, 20);
            this.checkBoxSC.TabIndex = 0;
            this.checkBoxSC.Text = "Seasoned Chicken";
            this.checkBoxSC.UseVisualStyleBackColor = true;
            // 
            // listBoxBasket
            // 
            this.listBoxBasket.FormattingEnabled = true;
            this.listBoxBasket.ItemHeight = 16;
            this.listBoxBasket.Location = new System.Drawing.Point(30, 305);
            this.listBoxBasket.Name = "listBoxBasket";
            this.listBoxBasket.Size = new System.Drawing.Size(259, 132);
            this.listBoxBasket.TabIndex = 10;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(445, 386);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(160, 48);
            this.buttonOrder.TabIndex = 11;
            this.buttonOrder.Text = "ORDER";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(330, 402);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(41, 16);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "Total:";
            // 
            // labelTotalValue
            // 
            this.labelTotalValue.AutoSize = true;
            this.labelTotalValue.Location = new System.Drawing.Point(377, 402);
            this.labelTotalValue.Name = "labelTotalValue";
            this.labelTotalValue.Size = new System.Drawing.Size(24, 16);
            this.labelTotalValue.TabIndex = 9;
            this.labelTotalValue.Text = "$ 0";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(317, 327);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(288, 32);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "ADD PIZZA";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelOrders
            // 
            this.labelOrders.AutoSize = true;
            this.labelOrders.Location = new System.Drawing.Point(668, 43);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(48, 16);
            this.labelOrders.TabIndex = 14;
            this.labelOrders.Text = "Orders";
            // 
            // richTextBoxOrders
            // 
            this.richTextBoxOrders.Location = new System.Drawing.Point(671, 74);
            this.richTextBoxOrders.Name = "richTextBoxOrders";
            this.richTextBoxOrders.ReadOnly = true;
            this.richTextBoxOrders.Size = new System.Drawing.Size(339, 360);
            this.richTextBoxOrders.TabIndex = 15;
            this.richTextBoxOrders.Text = "";
            // 
            // FormPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 470);
            this.Controls.Add(this.richTextBoxOrders);
            this.Controls.Add(this.labelOrders);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelTotalValue);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.listBoxBasket);
            this.Controls.Add(this.groupBoxIng);
            this.Controls.Add(this.label);
            this.Controls.Add(this.radioButtonCheesy);
            this.Controls.Add(this.radioButtonClassic);
            this.Controls.Add(this.listBoxPizza);
            this.Controls.Add(this.labelPizza);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.labelSize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPizza";
            this.Text = "PizzAsu";
            this.Load += new System.EventHandler(this.FormPizza_Load);
            this.groupBoxIng.ResumeLayout(false);
            this.groupBoxIng.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label labelPizza;
        private System.Windows.Forms.ListBox listBoxPizza;
        private System.Windows.Forms.RadioButton radioButtonClassic;
        private System.Windows.Forms.RadioButton radioButtonCheesy;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBoxIng;
        private System.Windows.Forms.CheckBox checkBoxIS;
        private System.Windows.Forms.CheckBox checkBoxMO;
        private System.Windows.Forms.CheckBox checkBoxOL;
        private System.Windows.Forms.CheckBox checkBoxPI;
        private System.Windows.Forms.CheckBox checkBoxCT;
        private System.Windows.Forms.CheckBox checkBoxMU;
        private System.Windows.Forms.CheckBox checkBoxJA;
        private System.Windows.Forms.CheckBox checkBoxSC;
        private System.Windows.Forms.ListBox listBoxBasket;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalValue;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.RichTextBox richTextBoxOrders;
    }
}

