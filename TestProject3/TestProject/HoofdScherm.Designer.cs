namespace TestProject
{
    partial class HoofdScherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoofdScherm));
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
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
            this.helpToolStripMenuItem});
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
            // 
            // visualizerenToolStripMenuItem
            // 
            this.visualizerenToolStripMenuItem.Name = "visualizerenToolStripMenuItem";
            this.visualizerenToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.visualizerenToolStripMenuItem.Text = "&Visualizeren";
            // 
            // exporterenToolStripMenuItem
            // 
            this.exporterenToolStripMenuItem.Name = "exporterenToolStripMenuItem";
            this.exporterenToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exporterenToolStripMenuItem.Text = "&Exporteren...";
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
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 368);
            this.listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(221, 28);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(281, 368);
            this.listBox2.TabIndex = 5;
            // 
            // HoofdScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 416);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.knopExporteren);
            this.Controls.Add(this.knopVisualizeren);
            this.Controls.Add(this.knopImporteren);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HoofdScherm";
            this.Text = "Motorozoid";
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;


    }
}

