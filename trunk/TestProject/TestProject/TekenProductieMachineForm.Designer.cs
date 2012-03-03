namespace Motorozoid
{
    partial class TekenProductieMachineForm
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
            this.motorListBox = new System.Windows.Forms.ListBox();
            this.overbrengingListBox = new System.Windows.Forms.ListBox();
            this.belastingListBox = new System.Windows.Forms.ListBox();
            this.motorLabel = new System.Windows.Forms.Label();
            this.overbrengingLabel = new System.Windows.Forms.Label();
            this.belastingLabel = new System.Windows.Forms.Label();
            this.motorHost = new System.Windows.Forms.Integration.ElementHost();
            this.overbrengingHost = new System.Windows.Forms.Integration.ElementHost();
            this.belastingHost = new System.Windows.Forms.Integration.ElementHost();
            this.productieMachineLabel = new System.Windows.Forms.Label();
            this.productieMachineComboBox = new System.Windows.Forms.ComboBox();
            this.AnnuleerButton = new System.Windows.Forms.Button();
            this.tekenTotaalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // motorListBox
            // 
            this.motorListBox.FormattingEnabled = true;
            this.motorListBox.Location = new System.Drawing.Point(12, 62);
            this.motorListBox.Name = "motorListBox";
            this.motorListBox.Size = new System.Drawing.Size(400, 69);
            this.motorListBox.TabIndex = 2;
            this.motorListBox.SelectedIndexChanged += new System.EventHandler(this.motorListBox_SelectedIndexChanged);
            // 
            // overbrengingListBox
            // 
            this.overbrengingListBox.FormattingEnabled = true;
            this.overbrengingListBox.Location = new System.Drawing.Point(418, 62);
            this.overbrengingListBox.Name = "overbrengingListBox";
            this.overbrengingListBox.Size = new System.Drawing.Size(400, 69);
            this.overbrengingListBox.TabIndex = 3;
            this.overbrengingListBox.SelectedIndexChanged += new System.EventHandler(this.overbrengingListBox_SelectedIndexChanged);
            // 
            // belastingListBox
            // 
            this.belastingListBox.FormattingEnabled = true;
            this.belastingListBox.Location = new System.Drawing.Point(824, 62);
            this.belastingListBox.Name = "belastingListBox";
            this.belastingListBox.Size = new System.Drawing.Size(400, 69);
            this.belastingListBox.TabIndex = 4;
            this.belastingListBox.SelectedIndexChanged += new System.EventHandler(this.belastingListBox_SelectedIndexChanged);
            // 
            // motorLabel
            // 
            this.motorLabel.AutoSize = true;
            this.motorLabel.Location = new System.Drawing.Point(12, 46);
            this.motorLabel.Name = "motorLabel";
            this.motorLabel.Size = new System.Drawing.Size(37, 13);
            this.motorLabel.TabIndex = 5;
            this.motorLabel.Text = "Motor:";
            // 
            // overbrengingLabel
            // 
            this.overbrengingLabel.AutoSize = true;
            this.overbrengingLabel.Location = new System.Drawing.Point(415, 43);
            this.overbrengingLabel.Name = "overbrengingLabel";
            this.overbrengingLabel.Size = new System.Drawing.Size(74, 13);
            this.overbrengingLabel.TabIndex = 6;
            this.overbrengingLabel.Text = "Overbrenging:";
            // 
            // belastingLabel
            // 
            this.belastingLabel.AutoSize = true;
            this.belastingLabel.Location = new System.Drawing.Point(821, 46);
            this.belastingLabel.Name = "belastingLabel";
            this.belastingLabel.Size = new System.Drawing.Size(53, 13);
            this.belastingLabel.TabIndex = 7;
            this.belastingLabel.Text = "Belasting:";
            // 
            // motorHost
            // 
            this.motorHost.Location = new System.Drawing.Point(12, 137);
            this.motorHost.Name = "motorHost";
            this.motorHost.Size = new System.Drawing.Size(400, 300);
            this.motorHost.TabIndex = 8;
            this.motorHost.Text = "elementHost1";
            this.motorHost.Child = null;
            // 
            // overbrengingHost
            // 
            this.overbrengingHost.Location = new System.Drawing.Point(418, 137);
            this.overbrengingHost.Name = "overbrengingHost";
            this.overbrengingHost.Size = new System.Drawing.Size(400, 300);
            this.overbrengingHost.TabIndex = 9;
            this.overbrengingHost.Text = "elementHost2";
            this.overbrengingHost.Child = null;
            // 
            // belastingHost
            // 
            this.belastingHost.Location = new System.Drawing.Point(824, 137);
            this.belastingHost.Name = "belastingHost";
            this.belastingHost.Size = new System.Drawing.Size(400, 300);
            this.belastingHost.TabIndex = 10;
            this.belastingHost.Text = "elementHost3";
            this.belastingHost.Child = null;
            // 
            // productieMachineLabel
            // 
            this.productieMachineLabel.AutoSize = true;
            this.productieMachineLabel.Location = new System.Drawing.Point(415, 13);
            this.productieMachineLabel.Name = "productieMachineLabel";
            this.productieMachineLabel.Size = new System.Drawing.Size(117, 13);
            this.productieMachineLabel.TabIndex = 11;
            this.productieMachineLabel.Text = "Kies productiemachine:";
            // 
            // productieMachineComboBox
            // 
            this.productieMachineComboBox.FormattingEnabled = true;
            this.productieMachineComboBox.Location = new System.Drawing.Point(538, 10);
            this.productieMachineComboBox.Name = "productieMachineComboBox";
            this.productieMachineComboBox.Size = new System.Drawing.Size(280, 21);
            this.productieMachineComboBox.TabIndex = 12;
            this.productieMachineComboBox.SelectedIndexChanged += new System.EventHandler(this.productieMachineComboBox_SelectedIndexChanged);
            // 
            // AnnuleerButton
            // 
            this.AnnuleerButton.Location = new System.Drawing.Point(1149, 443);
            this.AnnuleerButton.Name = "AnnuleerButton";
            this.AnnuleerButton.Size = new System.Drawing.Size(75, 23);
            this.AnnuleerButton.TabIndex = 13;
            this.AnnuleerButton.Text = "Annuleren";
            this.AnnuleerButton.UseVisualStyleBackColor = true;
            this.AnnuleerButton.Click += new System.EventHandler(this.AnnuleerButton_Click);
            // 
            // tekenTotaalButton
            // 
            this.tekenTotaalButton.Location = new System.Drawing.Point(1057, 443);
            this.tekenTotaalButton.Name = "tekenTotaalButton";
            this.tekenTotaalButton.Size = new System.Drawing.Size(86, 23);
            this.tekenTotaalButton.TabIndex = 14;
            this.tekenTotaalButton.Text = "Teken Totaal";
            this.tekenTotaalButton.UseVisualStyleBackColor = true;
            this.tekenTotaalButton.Click += new System.EventHandler(this.tekenTotaalButton_Click);
            // 
            // TekenProductieMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 476);
            this.Controls.Add(this.tekenTotaalButton);
            this.Controls.Add(this.AnnuleerButton);
            this.Controls.Add(this.productieMachineComboBox);
            this.Controls.Add(this.productieMachineLabel);
            this.Controls.Add(this.belastingHost);
            this.Controls.Add(this.overbrengingHost);
            this.Controls.Add(this.motorHost);
            this.Controls.Add(this.belastingLabel);
            this.Controls.Add(this.overbrengingLabel);
            this.Controls.Add(this.motorLabel);
            this.Controls.Add(this.belastingListBox);
            this.Controls.Add(this.overbrengingListBox);
            this.Controls.Add(this.motorListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "TekenProductieMachineForm";
            this.Text = "Teken ProductieMachines";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TekenProductieMachineForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox motorListBox;
        private System.Windows.Forms.ListBox overbrengingListBox;
        private System.Windows.Forms.ListBox belastingListBox;
        private System.Windows.Forms.Label motorLabel;
        private System.Windows.Forms.Label overbrengingLabel;
        private System.Windows.Forms.Label belastingLabel;
        private System.Windows.Forms.Integration.ElementHost motorHost;
        private System.Windows.Forms.Integration.ElementHost overbrengingHost;
        private System.Windows.Forms.Integration.ElementHost belastingHost;
        private System.Windows.Forms.Label productieMachineLabel;
        private System.Windows.Forms.ComboBox productieMachineComboBox;
        private System.Windows.Forms.Button AnnuleerButton;
        private System.Windows.Forms.Button tekenTotaalButton;
    }
}