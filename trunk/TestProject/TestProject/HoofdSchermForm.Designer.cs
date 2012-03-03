namespace Motorozoid
{
    partial class HoofdSchermForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoofdSchermForm));
            this.knopImporteren = new System.Windows.Forms.Button();
            this.knopVisualizeren = new System.Windows.Forms.Button();
            this.knopExporteren = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizerenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.uitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestandToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productiemachineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productiemachineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bestandenListBox = new System.Windows.Forms.ListBox();
            this.machinesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // knopImporteren
            // 
            this.knopImporteren.Image = ((System.Drawing.Image)(resources.GetObject("knopImporteren.Image")));
            this.knopImporteren.Location = new System.Drawing.Point(508, 28);
            this.knopImporteren.Name = "knopImporteren";
            this.knopImporteren.Size = new System.Drawing.Size(120, 120);
            this.knopImporteren.TabIndex = 0;
            this.knopImporteren.UseVisualStyleBackColor = true;
            this.knopImporteren.Click += new System.EventHandler(this.knopImporteren_Click);
            // 
            // knopVisualizeren
            // 
            this.knopVisualizeren.Image = ((System.Drawing.Image)(resources.GetObject("knopVisualizeren.Image")));
            this.knopVisualizeren.Location = new System.Drawing.Point(508, 155);
            this.knopVisualizeren.Name = "knopVisualizeren";
            this.knopVisualizeren.Size = new System.Drawing.Size(120, 120);
            this.knopVisualizeren.TabIndex = 1;
            this.knopVisualizeren.UseVisualStyleBackColor = true;
            this.knopVisualizeren.Click += new System.EventHandler(this.knopVisualizeren_Click);
            // 
            // knopExporteren
            // 
            this.knopExporteren.Image = ((System.Drawing.Image)(resources.GetObject("knopExporteren.Image")));
            this.knopExporteren.Location = new System.Drawing.Point(508, 282);
            this.knopExporteren.Name = "knopExporteren";
            this.knopExporteren.Size = new System.Drawing.Size(120, 120);
            this.knopExporteren.TabIndex = 2;
            this.knopExporteren.UseVisualStyleBackColor = true;
            this.knopExporteren.Click += new System.EventHandler(this.knopExporteren_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.editToolStripMenuItem,
            this.tekenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importerenToolStripMenuItem,
            this.visualizerenToolStripMenuItem,
            this.exporterenToolStripMenuItem,
            this.toolStripSeparator1,
            this.uitloggenToolStripMenuItem,
            this.toolStripSeparator2,
            this.afsluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "&Bestand";
            // 
            // importerenToolStripMenuItem
            // 
            this.importerenToolStripMenuItem.Name = "importerenToolStripMenuItem";
            this.importerenToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.importerenToolStripMenuItem.Text = "&Importeren...";
            this.importerenToolStripMenuItem.Click += new System.EventHandler(this.importerenToolStripMenuItem_Click);
            // 
            // visualizerenToolStripMenuItem
            // 
            this.visualizerenToolStripMenuItem.Name = "visualizerenToolStripMenuItem";
            this.visualizerenToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.visualizerenToolStripMenuItem.Text = "&Visualizeren";
            this.visualizerenToolStripMenuItem.Click += new System.EventHandler(this.visualizerenToolStripMenuItem_Click);
            // 
            // exporterenToolStripMenuItem
            // 
            this.exporterenToolStripMenuItem.Name = "exporterenToolStripMenuItem";
            this.exporterenToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exporterenToolStripMenuItem.Text = "&Exporteren...";
            this.exporterenToolStripMenuItem.Click += new System.EventHandler(this.exporterenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(139, 6);
            // 
            // uitloggenToolStripMenuItem
            // 
            this.uitloggenToolStripMenuItem.Name = "uitloggenToolStripMenuItem";
            this.uitloggenToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.uitloggenToolStripMenuItem.Text = "&Uitloggen";
            this.uitloggenToolStripMenuItem.Click += new System.EventHandler(this.uitloggenToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(139, 6);
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.afsluitenToolStripMenuItem.Text = "&Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem1,
            this.productiemachineToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.editToolStripMenuItem.Text = "Aanpassen";
            // 
            // bestandToolStripMenuItem1
            // 
            this.bestandToolStripMenuItem1.Name = "bestandToolStripMenuItem1";
            this.bestandToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.bestandToolStripMenuItem1.Text = "Bestanden";
            this.bestandToolStripMenuItem1.Click += new System.EventHandler(this.bestandenToolStripMenuItem_Click);
            // 
            // productiemachineToolStripMenuItem
            // 
            this.productiemachineToolStripMenuItem.Name = "productiemachineToolStripMenuItem";
            this.productiemachineToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.productiemachineToolStripMenuItem.Text = "Productiemachines";
            this.productiemachineToolStripMenuItem.Click += new System.EventHandler(this.productiemachinesToolStripMenuItem_Click);
            // 
            // tekenToolStripMenuItem
            // 
            this.tekenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productiemachineToolStripMenuItem1});
            this.tekenToolStripMenuItem.Name = "tekenToolStripMenuItem";
            this.tekenToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.tekenToolStripMenuItem.Text = "Teken";
            // 
            // productiemachineToolStripMenuItem1
            // 
            this.productiemachineToolStripMenuItem1.Name = "productiemachineToolStripMenuItem1";
            this.productiemachineToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.productiemachineToolStripMenuItem1.Text = "Productiemachine";
            this.productiemachineToolStripMenuItem1.Click += new System.EventHandler(this.productiemachineToolStripMenuItem_Click);
            // 
            // bestandenListBox
            // 
            this.bestandenListBox.FormattingEnabled = true;
            this.bestandenListBox.Location = new System.Drawing.Point(13, 54);
            this.bestandenListBox.Name = "bestandenListBox";
            this.bestandenListBox.Size = new System.Drawing.Size(317, 342);
            this.bestandenListBox.TabIndex = 4;
            this.bestandenListBox.SelectedIndexChanged += new System.EventHandler(this.bestandenListBox_SelectedIndexChanged);
            // 
            // machinesListBox
            // 
            this.machinesListBox.FormattingEnabled = true;
            this.machinesListBox.Location = new System.Drawing.Point(336, 54);
            this.machinesListBox.Name = "machinesListBox";
            this.machinesListBox.Size = new System.Drawing.Size(166, 342);
            this.machinesListBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bestanden:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Machines:";
            // 
            // HoofdSchermForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.machinesListBox);
            this.Controls.Add(this.bestandenListBox);
            this.Controls.Add(this.knopExporteren);
            this.Controls.Add(this.knopVisualizeren);
            this.Controls.Add(this.knopImporteren);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "HoofdSchermForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motorozoid";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HoofdSchermForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button knopImporteren;
        private System.Windows.Forms.Button knopVisualizeren;
        private System.Windows.Forms.Button knopExporteren;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizerenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem uitloggenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox bestandenListBox;
        private System.Windows.Forms.ListBox machinesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productiemachineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tekenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productiemachineToolStripMenuItem1;


    }
}

