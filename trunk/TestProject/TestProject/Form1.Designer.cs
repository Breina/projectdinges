namespace TestProject
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
            this.sqlToExcelButton = new System.Windows.Forms.Button();
            this.excelToSqlButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sqlToExcelButton
            // 
            this.sqlToExcelButton.Location = new System.Drawing.Point(12, 12);
            this.sqlToExcelButton.Name = "sqlToExcelButton";
            this.sqlToExcelButton.Size = new System.Drawing.Size(95, 30);
            this.sqlToExcelButton.TabIndex = 0;
            this.sqlToExcelButton.Text = "SQL to Excel";
            this.sqlToExcelButton.UseVisualStyleBackColor = true;
            this.sqlToExcelButton.Click += new System.EventHandler(this.sqlToExcelButton_Click);
            // 
            // excelToSqlButton
            // 
            this.excelToSqlButton.Location = new System.Drawing.Point(12, 48);
            this.excelToSqlButton.Name = "excelToSqlButton";
            this.excelToSqlButton.Size = new System.Drawing.Size(95, 30);
            this.excelToSqlButton.TabIndex = 1;
            this.excelToSqlButton.Text = "Excel to SQL";
            this.excelToSqlButton.UseVisualStyleBackColor = true;
            this.excelToSqlButton.Click += new System.EventHandler(this.excelToSqlButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "SQL to XAML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.excelToSqlButton);
            this.Controls.Add(this.sqlToExcelButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sqlToExcelButton;
        private System.Windows.Forms.Button excelToSqlButton;
        private System.Windows.Forms.Button button1;

    }
}

