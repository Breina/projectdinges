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
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColNaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vermogen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomToer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomKopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductieMachineNaam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnProductiemachines = new System.Windows.Forms.Button();
            this.laadDataProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kiesExcelButton
            // 
            this.kiesExcelButton.Location = new System.Drawing.Point(681, 11);
            this.kiesExcelButton.Name = "kiesExcelButton";
            this.kiesExcelButton.Size = new System.Drawing.Size(75, 23);
            this.kiesExcelButton.TabIndex = 1;
            this.kiesExcelButton.Text = "Bladeren...";
            this.kiesExcelButton.UseVisualStyleBackColor = true;
            this.kiesExcelButton.Click += new System.EventHandler(this.kiesExcelButton_Click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(13, 13);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(662, 20);
            this.fileTextBox.TabIndex = 0;
            this.fileTextBox.TabStop = false;
            this.fileTextBox.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNaam,
            this.Type,
            this.Label,
            this.Vermogen,
            this.NomToer,
            this.NomKopp,
            this.ProductieMachineNaam});
            this.dataGridView.Location = new System.Drawing.Point(13, 39);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(743, 309);
            this.dataGridView.TabIndex = 2;
            // 
            // ColNaam
            // 
            this.ColNaam.HeaderText = "Naam";
            this.ColNaam.Name = "ColNaam";
            this.ColNaam.ReadOnly = true;
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
            this.Vermogen.HeaderText = "Vermogen";
            this.Vermogen.Name = "Vermogen";
            // 
            // NomToer
            // 
            this.NomToer.HeaderText = "Toerental";
            this.NomToer.Name = "NomToer";
            // 
            // NomKopp
            // 
            this.NomKopp.HeaderText = "Koppel";
            this.NomKopp.Name = "NomKopp";
            // 
            // ProductieMachineNaam
            // 
            this.ProductieMachineNaam.HeaderText = "Productiemachine";
            this.ProductieMachineNaam.Name = "ProductieMachineNaam";
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(681, 354);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(600, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Annuleren";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // laadDataProgressBar
            // 
            this.laadDataProgressBar.Location = new System.Drawing.Point(147, 353);
            this.laadDataProgressBar.Name = "laadDataProgressBar";
            this.laadDataProgressBar.Size = new System.Drawing.Size(447, 23);
            this.laadDataProgressBar.TabIndex = 6;
            // 
            // ExcelToSqlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 389);
            this.Controls.Add(this.laadDataProgressBar);
            this.Controls.Add(this.btnProductiemachines);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.kiesExcelButton);
            this.Name = "ExcelToSqlForm";
            this.Text = "ExcelToSqlForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button kiesExcelButton;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnProductiemachines;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNaam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vermogen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomToer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomKopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductieMachineNaam;
        private System.Windows.Forms.ProgressBar laadDataProgressBar;
    }
}