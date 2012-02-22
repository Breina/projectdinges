namespace TestProject
{
    partial class SqlToExcelForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlToExcelButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.saveMapButton = new System.Windows.Forms.Button();
            this.mapTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geef het nummer van de data in:";
            // 
            // sqlToExcelButton
            // 
            this.sqlToExcelButton.Location = new System.Drawing.Point(172, 203);
            this.sqlToExcelButton.Name = "sqlToExcelButton";
            this.sqlToExcelButton.Size = new System.Drawing.Size(80, 37);
            this.sqlToExcelButton.TabIndex = 2;
            this.sqlToExcelButton.Text = "Zet om naar excel";
            this.sqlToExcelButton.UseVisualStyleBackColor = true;
            this.sqlToExcelButton.Click += new System.EventHandler(this.sqlToExcel_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(258, 175);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 3;
            // 
            // saveMapButton
            // 
            this.saveMapButton.Location = new System.Drawing.Point(12, 38);
            this.saveMapButton.Name = "saveMapButton";
            this.saveMapButton.Size = new System.Drawing.Size(75, 56);
            this.saveMapButton.TabIndex = 4;
            this.saveMapButton.Text = "Map waar je wil saven:";
            this.saveMapButton.UseVisualStyleBackColor = true;
            this.saveMapButton.Click += new System.EventHandler(this.saveMap_Click);
            // 
            // mapTextBox
            // 
            this.mapTextBox.Location = new System.Drawing.Point(93, 25);
            this.mapTextBox.Multiline = true;
            this.mapTextBox.Name = "mapTextBox";
            this.mapTextBox.ReadOnly = true;
            this.mapTextBox.Size = new System.Drawing.Size(285, 80);
            this.mapTextBox.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(38, 203);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 37);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SqlToExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 282);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.mapTextBox);
            this.Controls.Add(this.saveMapButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.sqlToExcelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "SqlToExcelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SqlToExcelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sqlToExcelButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button saveMapButton;
        private System.Windows.Forms.TextBox mapTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

        public System.EventHandler SqlToExcelForm_Load { get; set; }
    }
}