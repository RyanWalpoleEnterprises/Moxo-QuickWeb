namespace Moxo_Web_UI
{
    partial class Startup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            this.UI_WebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.UI_Button_Back = new System.Windows.Forms.ToolStripButton();
            this.UI_Button_Refresh = new System.Windows.Forms.ToolStripButton();
            this.UI_Button_Forward = new System.Windows.Forms.ToolStripButton();
            this.UI_Button_About = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.UI_WebView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_WebView
            // 
            this.UI_WebView.AllowExternalDrop = true;
            this.UI_WebView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_WebView.CreationProperties = null;
            this.UI_WebView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.UI_WebView.Location = new System.Drawing.Point(-1, 25);
            this.UI_WebView.Name = "UI_WebView";
            this.UI_WebView.Size = new System.Drawing.Size(787, 571);
            this.UI_WebView.TabIndex = 0;
            this.UI_WebView.ZoomFactor = 1D;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UI_Button_Back,
            this.UI_Button_Refresh,
            this.UI_Button_Forward,
            this.UI_Button_About});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // UI_Button_Back
            // 
            this.UI_Button_Back.Image = global::Moxo_Web_UI.Properties.Resources.Dark_Arrow_Left;
            this.UI_Button_Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UI_Button_Back.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
            this.UI_Button_Back.Name = "UI_Button_Back";
            this.UI_Button_Back.Size = new System.Drawing.Size(52, 22);
            this.UI_Button_Back.Text = "Back";
            this.UI_Button_Back.Click += new System.EventHandler(this.UI_Button_Back_Click);
            // 
            // UI_Button_Refresh
            // 
            this.UI_Button_Refresh.Image = global::Moxo_Web_UI.Properties.Resources.Dark_Reload;
            this.UI_Button_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UI_Button_Refresh.Margin = new System.Windows.Forms.Padding(7, 1, 0, 2);
            this.UI_Button_Refresh.Name = "UI_Button_Refresh";
            this.UI_Button_Refresh.Size = new System.Drawing.Size(66, 22);
            this.UI_Button_Refresh.Text = "Refresh";
            this.UI_Button_Refresh.Click += new System.EventHandler(this.UI_Button_Refresh_Click);
            // 
            // UI_Button_Forward
            // 
            this.UI_Button_Forward.Image = global::Moxo_Web_UI.Properties.Resources.ic_fluent_arrow_right_24_filled;
            this.UI_Button_Forward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UI_Button_Forward.Margin = new System.Windows.Forms.Padding(7, 1, 0, 2);
            this.UI_Button_Forward.Name = "UI_Button_Forward";
            this.UI_Button_Forward.Size = new System.Drawing.Size(70, 22);
            this.UI_Button_Forward.Text = "Forward";
            this.UI_Button_Forward.Click += new System.EventHandler(this.UI_Button_Forward_Click);
            // 
            // UI_Button_About
            // 
            this.UI_Button_About.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UI_Button_About.Image = global::Moxo_Web_UI.Properties.Resources.ic_fluent_chat_help_24_filled;
            this.UI_Button_About.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UI_Button_About.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.UI_Button_About.Name = "UI_Button_About";
            this.UI_Button_About.Size = new System.Drawing.Size(60, 22);
            this.UI_Button_About.Text = "About";
            this.UI_Button_About.Click += new System.EventHandler(this.UI_Button_About_Click);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 593);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.UI_WebView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Startup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "moxolib.userdefined.ApplicationName";
            ((System.ComponentModel.ISupportInitialize)(this.UI_WebView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 UI_WebView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton UI_Button_Back;
        private System.Windows.Forms.ToolStripButton UI_Button_Refresh;
        private System.Windows.Forms.ToolStripButton UI_Button_Forward;
        private System.Windows.Forms.ToolStripButton UI_Button_About;
    }
}

