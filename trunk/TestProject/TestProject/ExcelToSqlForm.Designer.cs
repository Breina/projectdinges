namespace TestProject
{
    partial class ExcelToSqlForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.kiesExcelButton = new System.Windows.Forms.Button();
            this.fileLabel = new System.Windows.Forms.Label();
            this.zetOmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kiesExcelButton
            // 
            this.kiesExcelButton.Location = new System.Drawing.Point(112, 12);
            this.kiesExcelButton.Name = "kiesExcelButton";
            this.kiesExcelButton.Size = new System.Drawing.Size(113, 36);
            this.kiesExcelButton.TabIndex = 0;
            this.kiesExcelButton.Text = "Kies excelbestand";
            this.kiesExcelButton.UseVisualStyleBackColor = true;
            this.kiesExcelButton.Click += new System.EventHandler(this.kiesExcelButton_Click);
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(12, 81);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(49, 13);
            this.fileLabel.TabIndex = 1;
            this.fileLabel.Text = "Bestand:";
            // 
            // zetOmButton
            // 
            this.zetOmButton.Location = new System.Drawing.Point(67, 166);
            this.zetOmButton.Name = "zetOmButton";
            this.zetOmButton.Size = new System.Drawing.Size(75, 23);
            this.zetOmButton.TabIndex = 2;
            this.zetOmButton.Text = "Zet om";
            this.zetOmButton.UseVisualStyleBackColor = true;
            this.zetOmButton.Click += new System.EventHandler(this.zetOmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(197, 166);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(67, 78);
            this.fileTextBox.Multiline = true;
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.ReadOnly = true;
            this.fileTextBox.Size = new System.Drawing.Size(205, 82);
            this.fileTextBox.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(67, 238);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 5;
            // 
            // ExcelToSqlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 402);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.zetOmButton);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.kiesExcelButton);
            this.Name = "ExcelToSqlForm";
            this.Text = "ExcelToSqlForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button kiesExcelButton;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Button zetOmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}