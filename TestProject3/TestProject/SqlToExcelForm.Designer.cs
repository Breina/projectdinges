namespace Motorozoid
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
            this.bestandLabel = new System.Windows.Forms.Label();
            this.naarExcelButton = new System.Windows.Forms.Button();
            this.bestandenListBox = new System.Windows.Forms.ListBox();
            this.annuleerButton = new System.Windows.Forms.Button();
            this.leegLabel = new System.Windows.Forms.Label();
            this.bestandsNaamTextBox = new System.Windows.Forms.TextBox();
            this.excelFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.bestandsNaamLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bestandLabel
            // 
            this.bestandLabel.AutoSize = true;
            this.bestandLabel.Location = new System.Drawing.Point(9, 15);
            this.bestandLabel.Name = "bestandLabel";
            this.bestandLabel.Size = new System.Drawing.Size(92, 13);
            this.bestandLabel.TabIndex = 1;
            this.bestandLabel.Text = "Kies een bestand:";
            // 
            // naarExcelButton
            // 
            this.naarExcelButton.Location = new System.Drawing.Point(409, 152);
            this.naarExcelButton.Name = "naarExcelButton";
            this.naarExcelButton.Size = new System.Drawing.Size(75, 23);
            this.naarExcelButton.TabIndex = 2;
            this.naarExcelButton.Text = "Zet om";
            this.naarExcelButton.UseVisualStyleBackColor = true;
            this.naarExcelButton.Click += new System.EventHandler(this.naarExcelButton_Click);
            // 
            // bestandenListBox
            // 
            this.bestandenListBox.FormattingEnabled = true;
            this.bestandenListBox.Location = new System.Drawing.Point(12, 38);
            this.bestandenListBox.Name = "bestandenListBox";
            this.bestandenListBox.Size = new System.Drawing.Size(472, 108);
            this.bestandenListBox.TabIndex = 3;
            this.bestandenListBox.SelectedIndexChanged += new System.EventHandler(this.bestandenListBox_SelectedIndexChanged);
            // 
            // annuleerButton
            // 
            this.annuleerButton.Location = new System.Drawing.Point(328, 153);
            this.annuleerButton.Name = "annuleerButton";
            this.annuleerButton.Size = new System.Drawing.Size(75, 23);
            this.annuleerButton.TabIndex = 6;
            this.annuleerButton.Text = "Annuleren";
            this.annuleerButton.UseVisualStyleBackColor = true;
            this.annuleerButton.Click += new System.EventHandler(this.anulleerButton_Click);
            // 
            // leegLabel
            // 
            this.leegLabel.AutoSize = true;
            this.leegLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leegLabel.Location = new System.Drawing.Point(9, 158);
            this.leegLabel.Name = "leegLabel";
            this.leegLabel.Size = new System.Drawing.Size(0, 18);
            this.leegLabel.TabIndex = 11;
            // 
            // bestandsNaamTextBox
            // 
            this.bestandsNaamTextBox.Location = new System.Drawing.Point(316, 12);
            this.bestandsNaamTextBox.Name = "bestandsNaamTextBox";
            this.bestandsNaamTextBox.Size = new System.Drawing.Size(168, 20);
            this.bestandsNaamTextBox.TabIndex = 12;
            // 
            // bestandsNaamLabel
            // 
            this.bestandsNaamLabel.AutoSize = true;
            this.bestandsNaamLabel.Location = new System.Drawing.Point(216, 15);
            this.bestandsNaamLabel.Name = "bestandsNaamLabel";
            this.bestandsNaamLabel.Size = new System.Drawing.Size(94, 13);
            this.bestandsNaamLabel.TabIndex = 13;
            this.bestandsNaamLabel.Text = "Geef een naam in:";
            // 
            // SqlToExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 188);
            this.Controls.Add(this.bestandsNaamLabel);
            this.Controls.Add(this.bestandsNaamTextBox);
            this.Controls.Add(this.leegLabel);
            this.Controls.Add(this.annuleerButton);
            this.Controls.Add(this.bestandenListBox);
            this.Controls.Add(this.naarExcelButton);
            this.Controls.Add(this.bestandLabel);
            this.Name = "SqlToExcelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SqlToExcelForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SqlToExcelForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bestandLabel;
        private System.Windows.Forms.Button naarExcelButton;
        private System.Windows.Forms.ListBox bestandenListBox;
        private System.Windows.Forms.Button annuleerButton;
        private System.Windows.Forms.Label leegLabel;
        private System.Windows.Forms.TextBox bestandsNaamTextBox;
        private System.Windows.Forms.FolderBrowserDialog excelFolderBrowserDialog;
        private System.Windows.Forms.Label bestandsNaamLabel;

        public System.EventHandler SqlToExcelForm_Load { get; set; }
    }
}