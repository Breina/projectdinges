﻿namespace Motorozoid
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
            this.rendamentLabel = new System.Windows.Forms.Label();
            this.toerentalLabel = new System.Windows.Forms.Label();
            this.koppelLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grafiekHost
            // 
            this.grafiekHost.Dock = System.Windows.Forms.DockStyle.Top;
            this.grafiekHost.Location = new System.Drawing.Point(0, 0);
            this.grafiekHost.Name = "grafiekHost";
            this.grafiekHost.Size = new System.Drawing.Size(519, 268);
            this.grafiekHost.TabIndex = 1;
            this.grafiekHost.Text = "elementHost1";
            this.grafiekHost.Child = null;
            // 
            // rendamentLabel
            // 
            this.rendamentLabel.AutoSize = true;
            this.rendamentLabel.Location = new System.Drawing.Point(108, 309);
            this.rendamentLabel.Name = "rendamentLabel";
            this.rendamentLabel.Size = new System.Drawing.Size(0, 13);
            this.rendamentLabel.TabIndex = 2;
            // 
            // toerentalLabel
            // 
            this.toerentalLabel.AutoSize = true;
            this.toerentalLabel.Location = new System.Drawing.Point(108, 332);
            this.toerentalLabel.Name = "toerentalLabel";
            this.toerentalLabel.Size = new System.Drawing.Size(0, 13);
            this.toerentalLabel.TabIndex = 3;
            // 
            // koppelLabel
            // 
            this.koppelLabel.AutoSize = true;
            this.koppelLabel.Location = new System.Drawing.Point(108, 354);
            this.koppelLabel.Name = "koppelLabel";
            this.koppelLabel.Size = new System.Drawing.Size(0, 13);
            this.koppelLabel.TabIndex = 4;
            // 
            // GrafiekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 480);
            this.Controls.Add(this.koppelLabel);
            this.Controls.Add(this.toerentalLabel);
            this.Controls.Add(this.rendamentLabel);
            this.Controls.Add(this.grafiekHost);
            this.Name = "GrafiekForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost grafiekHost;
        private System.Windows.Forms.Label rendamentLabel;
        private System.Windows.Forms.Label toerentalLabel;
        private System.Windows.Forms.Label koppelLabel;
       

    }
}