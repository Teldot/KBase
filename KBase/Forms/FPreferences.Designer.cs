namespace KBase.View.Forms
{
    partial class FPreferences
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
            this.llMThemes = new System.Windows.Forms.LinkLabel();
            this.llMKAreas = new System.Windows.Forms.LinkLabel();
            this.llMTags = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // llMThemes
            // 
            this.llMThemes.AutoSize = true;
            this.llMThemes.Location = new System.Drawing.Point(31, 108);
            this.llMThemes.Name = "llMThemes";
            this.llMThemes.Size = new System.Drawing.Size(87, 13);
            this.llMThemes.TabIndex = 0;
            this.llMThemes.TabStop = true;
            this.llMThemes.Text = "Manage Themes";
            this.llMThemes.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llMThemes_LinkClicked);
            // 
            // llMKAreas
            // 
            this.llMKAreas.AutoSize = true;
            this.llMKAreas.Location = new System.Drawing.Point(31, 78);
            this.llMKAreas.Name = "llMKAreas";
            this.llMKAreas.Size = new System.Drawing.Size(132, 13);
            this.llMKAreas.TabIndex = 1;
            this.llMKAreas.TabStop = true;
            this.llMKAreas.Text = "Manage Knowledge Areas";
            this.llMKAreas.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llMKAreas_LinkClicked);
            // 
            // llMTags
            // 
            this.llMTags.AutoSize = true;
            this.llMTags.Location = new System.Drawing.Point(31, 140);
            this.llMTags.Name = "llMTags";
            this.llMTags.Size = new System.Drawing.Size(73, 13);
            this.llMTags.TabIndex = 2;
            this.llMTags.TabStop = true;
            this.llMTags.Text = "Manage Tags";
            this.llMTags.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llMTags_LinkClicked);
            // 
            // FPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 200);
            this.Controls.Add(this.llMTags);
            this.Controls.Add(this.llMKAreas);
            this.Controls.Add(this.llMThemes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FPreferences";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.FPreferences_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llMThemes;
        private System.Windows.Forms.LinkLabel llMKAreas;
        private System.Windows.Forms.LinkLabel llMTags;
    }
}