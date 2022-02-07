namespace W06_01_FileFolder
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
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonFolder = new System.Windows.Forms.Button();
            this.buttonMoveFolder = new System.Windows.Forms.Button();
            this.buttonCopyFile = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(50, 129);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(146, 23);
            this.buttonFile.TabIndex = 0;
            this.buttonFile.Text = "Create File";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonFolder
            // 
            this.buttonFolder.Location = new System.Drawing.Point(50, 29);
            this.buttonFolder.Name = "buttonFolder";
            this.buttonFolder.Size = new System.Drawing.Size(146, 23);
            this.buttonFolder.TabIndex = 1;
            this.buttonFolder.Text = "Create Folder";
            this.buttonFolder.UseVisualStyleBackColor = true;
            this.buttonFolder.Click += new System.EventHandler(this.buttonFolder_Click);
            // 
            // buttonMoveFolder
            // 
            this.buttonMoveFolder.Location = new System.Drawing.Point(50, 81);
            this.buttonMoveFolder.Name = "buttonMoveFolder";
            this.buttonMoveFolder.Size = new System.Drawing.Size(146, 23);
            this.buttonMoveFolder.TabIndex = 2;
            this.buttonMoveFolder.Text = "Move Folder";
            this.buttonMoveFolder.UseVisualStyleBackColor = true;
            this.buttonMoveFolder.Click += new System.EventHandler(this.buttonMoveFolder_Click);
            // 
            // buttonCopyFile
            // 
            this.buttonCopyFile.Location = new System.Drawing.Point(50, 175);
            this.buttonCopyFile.Name = "buttonCopyFile";
            this.buttonCopyFile.Size = new System.Drawing.Size(146, 23);
            this.buttonCopyFile.TabIndex = 0;
            this.buttonCopyFile.Text = "Copy File";
            this.buttonCopyFile.UseVisualStyleBackColor = true;
            this.buttonCopyFile.Click += new System.EventHandler(this.buttonCopyFile_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(50, 219);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(146, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete File";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode =  System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonMoveFolder);
            this.Controls.Add(this.buttonFolder);
            this.Controls.Add(this.buttonCopyFile);
            this.Controls.Add(this.buttonFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonFolder;
        private System.Windows.Forms.Button buttonMoveFolder;
        private System.Windows.Forms.Button buttonCopyFile;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button1;
    }
}

