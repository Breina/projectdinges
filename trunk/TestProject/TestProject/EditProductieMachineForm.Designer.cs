namespace Motorozoid
{
    partial class EditProductieMachineForm
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
            this.productieMachineLabel = new System.Windows.Forms.Label();
            this.productieMachineComboBox = new System.Windows.Forms.ComboBox();
            this.naamLabel = new System.Windows.Forms.Label();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.annuleerButton = new System.Windows.Forms.Button();
            this.opslaanButton = new System.Windows.Forms.Button();
            this.toevoegenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productieMachineLabel
            // 
            this.productieMachineLabel.AutoSize = true;
            this.productieMachineLabel.Location = new System.Drawing.Point(12, 24);
            this.productieMachineLabel.Name = "productieMachineLabel";
            this.productieMachineLabel.Size = new System.Drawing.Size(117, 13);
            this.productieMachineLabel.TabIndex = 0;
            this.productieMachineLabel.Text = "Kies productiemachine:";
            // 
            // productieMachineComboBox
            // 
            this.productieMachineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productieMachineComboBox.FormattingEnabled = true;
            this.productieMachineComboBox.Location = new System.Drawing.Point(135, 21);
            this.productieMachineComboBox.Name = "productieMachineComboBox";
            this.productieMachineComboBox.Size = new System.Drawing.Size(176, 21);
            this.productieMachineComboBox.TabIndex = 1;
            this.productieMachineComboBox.SelectedIndexChanged += new System.EventHandler(this.productieMachineComboBox_SelectedIndexChanged);
            // 
            // naamLabel
            // 
            this.naamLabel.AutoSize = true;
            this.naamLabel.Location = new System.Drawing.Point(12, 61);
            this.naamLabel.Name = "naamLabel";
            this.naamLabel.Size = new System.Drawing.Size(38, 13);
            this.naamLabel.TabIndex = 2;
            this.naamLabel.Text = "Naam:";
            // 
            // naamTextBox
            // 
            this.naamTextBox.Location = new System.Drawing.Point(135, 58);
            this.naamTextBox.MaxLength = 50;
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(176, 20);
            this.naamTextBox.TabIndex = 3;
            // 
            // annuleerButton
            // 
            this.annuleerButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annuleerButton.Location = new System.Drawing.Point(228, 84);
            this.annuleerButton.Name = "annuleerButton";
            this.annuleerButton.Size = new System.Drawing.Size(83, 23);
            this.annuleerButton.TabIndex = 4;
            this.annuleerButton.Text = "Annuleren";
            this.annuleerButton.UseVisualStyleBackColor = true;
            this.annuleerButton.Click += new System.EventHandler(this.annuleerButton_Click);
            // 
            // opslaanButton
            // 
            this.opslaanButton.Location = new System.Drawing.Point(134, 84);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(88, 23);
            this.opslaanButton.TabIndex = 5;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.UseVisualStyleBackColor = true;
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click);
            // 
            // toevoegenButton
            // 
            this.toevoegenButton.Location = new System.Drawing.Point(12, 84);
            this.toevoegenButton.Name = "toevoegenButton";
            this.toevoegenButton.Size = new System.Drawing.Size(116, 23);
            this.toevoegenButton.TabIndex = 6;
            this.toevoegenButton.Text = "Nieuwe Toevoegen";
            this.toevoegenButton.UseVisualStyleBackColor = true;
            this.toevoegenButton.Click += new System.EventHandler(this.toevoegenButton_Click);
            // 
            // EditProductieMachineForm
            // 
            this.AcceptButton = this.opslaanButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.annuleerButton;
            this.ClientSize = new System.Drawing.Size(328, 128);
            this.Controls.Add(this.toevoegenButton);
            this.Controls.Add(this.opslaanButton);
            this.Controls.Add(this.annuleerButton);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(this.naamLabel);
            this.Controls.Add(this.productieMachineComboBox);
            this.Controls.Add(this.productieMachineLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "EditProductieMachineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aanpassen Productiemachine";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditProductieMachineForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productieMachineLabel;
        private System.Windows.Forms.ComboBox productieMachineComboBox;
        private System.Windows.Forms.Label naamLabel;
        private System.Windows.Forms.TextBox naamTextBox;
        private System.Windows.Forms.Button annuleerButton;
        private System.Windows.Forms.Button opslaanButton;
        private System.Windows.Forms.Button toevoegenButton;
    }
}