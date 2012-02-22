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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.kiesExcelButton = new System.Windows.Forms.Button();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.opslaanButton = new System.Windows.Forms.Button();
            this.annuleerButton = new System.Windows.Forms.Button();
            this.btnProductiemachines = new System.Windows.Forms.Button();
            this.machinesDataGridView = new System.Windows.Forms.DataGridView();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vermogen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NominaalToerental = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NominaalKoppel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.machinesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kiesExcelButton
            // 
            this.kiesExcelButton.Location = new System.Drawing.Point(621, 11);
            this.kiesExcelButton.Name = "kiesExcelButton";
            this.kiesExcelButton.Size = new System.Drawing.Size(75, 23);
            this.kiesExcelButton.TabIndex = 1;
            this.kiesExcelButton.Text = "Bladeren...";
            this.kiesExcelButton.UseVisualStyleBackColor = true;
            this.kiesExcelButton.Click += new System.EventHandler(this.kiesExcelButton_Click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(12, 13);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(603, 20);
            this.fileTextBox.TabIndex = 0;
            this.fileTextBox.TabStop = false;
            this.fileTextBox.Click += new System.EventHandler(this.fileTextBox_Click);
            // 
            // opslaanButton
            // 
            this.opslaanButton.Enabled = false;
            this.opslaanButton.Location = new System.Drawing.Point(621, 353);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(75, 23);
            this.opslaanButton.TabIndex = 3;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.UseVisualStyleBackColor = true;
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click);
            // 
            // annuleerButton
            // 
            this.annuleerButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annuleerButton.Location = new System.Drawing.Point(540, 353);
            this.annuleerButton.Name = "annuleerButton";
            this.annuleerButton.Size = new System.Drawing.Size(75, 23);
            this.annuleerButton.TabIndex = 4;
            this.annuleerButton.Text = "Annuleren";
            this.annuleerButton.UseVisualStyleBackColor = true;
            this.annuleerButton.Click += new System.EventHandler(this.annuleerButton_Click);
            // 
            // btnProductiemachines
            // 
            this.btnProductiemachines.Location = new System.Drawing.Point(13, 353);
            this.btnProductiemachines.Name = "btnProductiemachines";
            this.btnProductiemachines.Size = new System.Drawing.Size(128, 23);
            this.btnProductiemachines.TabIndex = 5;
            this.btnProductiemachines.Text = "Productiemachines";
            this.btnProductiemachines.UseVisualStyleBackColor = true;
            // 
            // machinesDataGridView
            // 
            this.machinesDataGridView.AllowUserToAddRows = false;
            this.machinesDataGridView.AllowUserToDeleteRows = false;
            this.machinesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.machinesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naam,
            this.Type,
            this.Label,
            this.Vermogen,
            this.NominaalToerental,
            this.NominaalKoppel});
            this.machinesDataGridView.Location = new System.Drawing.Point(13, 39);
            this.machinesDataGridView.Name = "machinesDataGridView";
            this.machinesDataGridView.Size = new System.Drawing.Size(683, 308);
            this.machinesDataGridView.TabIndex = 5;
            // 
            // Naam
            // 
            this.Naam.HeaderText = "Naam";
            this.Naam.Name = "Naam";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Label
            // 
            this.Label.HeaderText = "Label";
            this.Label.Name = "Label";
            // 
            // Vermogen
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = "0";
            this.Vermogen.DefaultCellStyle = dataGridViewCellStyle1;
            this.Vermogen.HeaderText = "Vermogen(kW)";
            this.Vermogen.Name = "Vermogen";
            // 
            // NominaalToerental
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.NominaalToerental.DefaultCellStyle = dataGridViewCellStyle2;
            this.NominaalToerental.HeaderText = "Nominaal-Toerental";
            this.NominaalToerental.Name = "NominaalToerental";
            // 
            // NominaalKoppel
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.NominaalKoppel.DefaultCellStyle = dataGridViewCellStyle3;
            this.NominaalKoppel.HeaderText = "Nominaal-Koppel";
            this.NominaalKoppel.Name = "NominaalKoppel";
            // 
            // ExcelToSqlForm
            // 
            this.AcceptButton = this.opslaanButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.annuleerButton;
            this.ClientSize = new System.Drawing.Size(707, 398);
            this.Controls.Add(this.machinesDataGridView);
            this.Controls.Add(this.btnProductiemachines);
            this.Controls.Add(this.annuleerButton);
            this.Controls.Add(this.opslaanButton);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.kiesExcelButton);
            this.Name = "ExcelToSqlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExcelToSqlForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExcelToSqlForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.machinesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button kiesExcelButton;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Button opslaanButton;
        private System.Windows.Forms.Button annuleerButton;
        private System.Windows.Forms.Button btnProductiemachines;
        private System.Windows.Forms.DataGridView machinesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vermogen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NominaalToerental;
        private System.Windows.Forms.DataGridViewTextBoxColumn NominaalKoppel;
       
    }
}