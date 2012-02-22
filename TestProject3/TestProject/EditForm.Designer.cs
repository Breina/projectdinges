namespace TestProject
{
    partial class EditForm
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
            System.Windows.Forms.Label bestandPadLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bestandPadComboBox = new System.Windows.Forms.ComboBox();
            this.machinesDataGridView = new System.Windows.Forms.DataGridView();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vermogen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NominaalToerental = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NominaalKoppel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verwijderButton = new System.Windows.Forms.Button();
            this.opslaanButton = new System.Windows.Forms.Button();
            this.annuleerButton = new System.Windows.Forms.Button();
            this.bestandLabel = new System.Windows.Forms.Label();
            bestandPadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.machinesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bestandPadLabel
            // 
            bestandPadLabel.AutoSize = true;
            bestandPadLabel.Location = new System.Drawing.Point(9, 12);
            bestandPadLabel.Name = "bestandPadLabel";
            bestandPadLabel.Size = new System.Drawing.Size(71, 13);
            bestandPadLabel.TabIndex = 0;
            bestandPadLabel.Text = "Bestand Pad:";
            // 
            // bestandPadComboBox
            // 
            this.bestandPadComboBox.FormattingEnabled = true;
            this.bestandPadComboBox.Location = new System.Drawing.Point(86, 9);
            this.bestandPadComboBox.Name = "bestandPadComboBox";
            this.bestandPadComboBox.Size = new System.Drawing.Size(467, 21);
            this.bestandPadComboBox.TabIndex = 1;
            this.bestandPadComboBox.SelectedIndexChanged += new System.EventHandler(this.bestandPadComboBox_SelectedIndexChanged);
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
            this.machinesDataGridView.Location = new System.Drawing.Point(12, 36);
            this.machinesDataGridView.Name = "machinesDataGridView";
            this.machinesDataGridView.Size = new System.Drawing.Size(668, 273);
            this.machinesDataGridView.TabIndex = 6;
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
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = "0";
            this.Vermogen.DefaultCellStyle = dataGridViewCellStyle10;
            this.Vermogen.HeaderText = "Vermogen(kW)";
            this.Vermogen.Name = "Vermogen";
            // 
            // NominaalToerental
            // 
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = "0";
            this.NominaalToerental.DefaultCellStyle = dataGridViewCellStyle11;
            this.NominaalToerental.HeaderText = "Nominaal-Toerental";
            this.NominaalToerental.Name = "NominaalToerental";
            // 
            // NominaalKoppel
            // 
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = "0";
            this.NominaalKoppel.DefaultCellStyle = dataGridViewCellStyle12;
            this.NominaalKoppel.HeaderText = "Nominaal-Koppel";
            this.NominaalKoppel.Name = "NominaalKoppel";
            // 
            // verwijderButton
            // 
            this.verwijderButton.Location = new System.Drawing.Point(559, 7);
            this.verwijderButton.Name = "verwijderButton";
            this.verwijderButton.Size = new System.Drawing.Size(121, 23);
            this.verwijderButton.TabIndex = 7;
            this.verwijderButton.Text = "Verwijder bestand";
            this.verwijderButton.UseVisualStyleBackColor = true;
            this.verwijderButton.Click += new System.EventHandler(this.verwijderButton_Click);
            // 
            // opslaanButton
            // 
            this.opslaanButton.Location = new System.Drawing.Point(605, 315);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(75, 23);
            this.opslaanButton.TabIndex = 8;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.UseVisualStyleBackColor = true;
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click);
            // 
            // annuleerButton
            // 
            this.annuleerButton.Location = new System.Drawing.Point(524, 315);
            this.annuleerButton.Name = "annuleerButton";
            this.annuleerButton.Size = new System.Drawing.Size(75, 23);
            this.annuleerButton.TabIndex = 9;
            this.annuleerButton.Text = "Annuleren";
            this.annuleerButton.UseVisualStyleBackColor = true;
            this.annuleerButton.Click += new System.EventHandler(this.annuleerButton_Click);
            // 
            // bestandLabel
            // 
            this.bestandLabel.AutoSize = true;
            this.bestandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestandLabel.Location = new System.Drawing.Point(12, 320);
            this.bestandLabel.Name = "bestandLabel";
            this.bestandLabel.Size = new System.Drawing.Size(0, 18);
            this.bestandLabel.TabIndex = 10;
            // 
            // EditForm
            // 
            this.AcceptButton = this.opslaanButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.annuleerButton;
            this.ClientSize = new System.Drawing.Size(692, 347);
            this.Controls.Add(this.bestandLabel);
            this.Controls.Add(this.annuleerButton);
            this.Controls.Add(this.opslaanButton);
            this.Controls.Add(this.verwijderButton);
            this.Controls.Add(this.machinesDataGridView);
            this.Controls.Add(bestandPadLabel);
            this.Controls.Add(this.bestandPadComboBox);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditBestand";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditBestand_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.machinesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bestandPadComboBox;
        private System.Windows.Forms.DataGridView machinesDataGridView;
        private System.Windows.Forms.Button verwijderButton;
        private System.Windows.Forms.Button opslaanButton;
        private System.Windows.Forms.Button annuleerButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewComboBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vermogen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NominaalToerental;
        private System.Windows.Forms.DataGridViewTextBoxColumn NominaalKoppel;
        private System.Windows.Forms.Label bestandLabel;

    }
}