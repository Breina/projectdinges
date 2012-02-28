namespace Motorozoid
{
    partial class Graph
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
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.grafiek1 = new IntensityChart.Grafiek();
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(12, 24);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(423, 268);
            this.elementHost1.TabIndex = 1;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.grafiek1;
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 480);
            this.Controls.Add(this.elementHost1);
            this.Name = "Graph";
            this.Text = "Graph";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private IntensityChart.Grafiek grafiek1;

    }
}