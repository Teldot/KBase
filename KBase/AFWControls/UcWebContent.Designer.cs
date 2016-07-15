namespace KBase.View.AFWControls
{
    partial class UcWebContent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wBrowser = new WebKit.WebKitBrowser();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.cbDynamicContent = new System.Windows.Forms.CheckBox();
            this.pbLoad = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // wBrowser
            // 
            this.wBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wBrowser.BackColor = System.Drawing.Color.White;
            this.wBrowser.Location = new System.Drawing.Point(0, 60);
            this.wBrowser.Name = "wBrowser";
            this.wBrowser.Size = new System.Drawing.Size(403, 287);
            this.wBrowser.TabIndex = 0;
            this.wBrowser.Url = null;
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.Location = new System.Drawing.Point(3, 5);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(359, 20);
            this.tbUrl.TabIndex = 1;
            this.tbUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUrl_KeyPress);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(368, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(32, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = ">>";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // cbDynamicContent
            // 
            this.cbDynamicContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDynamicContent.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbDynamicContent.AutoSize = true;
            this.cbDynamicContent.Location = new System.Drawing.Point(280, 31);
            this.cbDynamicContent.Name = "cbDynamicContent";
            this.cbDynamicContent.Size = new System.Drawing.Size(120, 23);
            this.cbDynamicContent.TabIndex = 3;
            this.cbDynamicContent.Text = "Auto  Update Content";
            this.cbDynamicContent.UseVisualStyleBackColor = true;
            // 
            // pbLoad
            // 
            this.pbLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLoad.Location = new System.Drawing.Point(3, 26);
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.Size = new System.Drawing.Size(359, 5);
            this.pbLoad.TabIndex = 4;
            // 
            // UcWebContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbLoad);
            this.Controls.Add(this.cbDynamicContent);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.wBrowser);
            this.Name = "UcWebContent";
            this.Size = new System.Drawing.Size(403, 347);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WebKit.WebKitBrowser wBrowser;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.CheckBox cbDynamicContent;
        private System.Windows.Forms.ProgressBar pbLoad;
    }
}
