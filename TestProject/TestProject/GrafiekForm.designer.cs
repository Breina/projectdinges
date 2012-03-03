namespace Motorozoid
{
    partial class GrafiekForm
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
            this.grafiekHost = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            // 
            // grafiekHost
            // 
            this.grafiekHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grafiekHost.Location = new System.Drawing.Point(0, 0);
            this.grafiekHost.Name = "grafiekHost";
            this.grafiekHost.Size = new System.Drawing.Size(519, 304);
            this.grafiekHost.TabIndex = 1;
            this.grafiekHost.Text = "elementHost1";
            this.grafiekHost.Child = null;
            // 
            // GrafiekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 304);
            this.Controls.Add(this.grafiekHost);
            this.Name = "GrafiekForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost grafiekHost;
       

    }
}