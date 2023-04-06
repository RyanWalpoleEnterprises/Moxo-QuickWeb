namespace Moxo_QuickWeb
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StartDotNet = new System.Windows.Forms.Button();
            this.StartDotLX = new System.Windows.Forms.Button();
            this.DocsDotNet = new System.Windows.Forms.Button();
            this.DocsDotLX = new System.Windows.Forms.Button();
            this.Version = new System.Windows.Forms.Label();
            this.UpdateCheck = new System.ComponentModel.BackgroundWorker();
            this.DelayUpdateCheck = new System.Windows.Forms.Timer(this.components);
            this.UpdateDotLX = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdatePanel = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SettingManagement = new System.Windows.Forms.RichTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Settings = new System.Windows.Forms.LinkLabel();
            this.CheckForUpdates = new System.Windows.Forms.LinkLabel();
            this.IssueReport = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.UpdatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label1.Location = new System.Drawing.Point(19, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turn your web-application into a Windows Desktop application with .NET that can b" +
    "e edited and expanded upon with Visual Studio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label2.Location = new System.Drawing.Point(327, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 77);
            this.label2.TabIndex = 3;
            this.label2.Text = "Turn your web-application into a Windows Desktop application with dotLX, the succ" +
    "essor to the Code LX programming language.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 19.25F);
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "Get Started";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label4.Location = new System.Drawing.Point(13, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(538, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "What would you like to do today?";
            // 
            // StartDotNet
            // 
            this.StartDotNet.Location = new System.Drawing.Point(327, 415);
            this.StartDotNet.Name = "StartDotNet";
            this.StartDotNet.Size = new System.Drawing.Size(240, 29);
            this.StartDotNet.TabIndex = 7;
            this.StartDotNet.Text = "Create New Application";
            this.StartDotNet.UseVisualStyleBackColor = true;
            this.StartDotNet.Click += new System.EventHandler(this.StartDotNet_Click);
            // 
            // StartDotLX
            // 
            this.StartDotLX.Location = new System.Drawing.Point(28, 415);
            this.StartDotLX.Name = "StartDotLX";
            this.StartDotLX.Size = new System.Drawing.Size(240, 29);
            this.StartDotLX.TabIndex = 8;
            this.StartDotLX.Text = "Create New Application";
            this.StartDotLX.UseVisualStyleBackColor = true;
            this.StartDotLX.Click += new System.EventHandler(this.StartDotLX_Click);
            // 
            // DocsDotNet
            // 
            this.DocsDotNet.Location = new System.Drawing.Point(28, 448);
            this.DocsDotNet.Name = "DocsDotNet";
            this.DocsDotNet.Size = new System.Drawing.Size(240, 29);
            this.DocsDotNet.TabIndex = 9;
            this.DocsDotNet.Text = "Documentation";
            this.DocsDotNet.UseVisualStyleBackColor = true;
            this.DocsDotNet.Click += new System.EventHandler(this.DocsDotNet_Click);
            // 
            // DocsDotLX
            // 
            this.DocsDotLX.Location = new System.Drawing.Point(450, 448);
            this.DocsDotLX.Name = "DocsDotLX";
            this.DocsDotLX.Size = new System.Drawing.Size(117, 29);
            this.DocsDotLX.TabIndex = 10;
            this.DocsDotLX.Text = "Documentation";
            this.DocsDotLX.UseVisualStyleBackColor = true;
            this.DocsDotLX.Click += new System.EventHandler(this.DocsDotLX_Click);
            // 
            // Version
            // 
            this.Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Version.ForeColor = System.Drawing.Color.Gray;
            this.Version.Location = new System.Drawing.Point(6, 507);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(169, 23);
            this.Version.TabIndex = 11;
            this.Version.Text = "Version: ";
            this.Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UpdateCheck
            // 
            this.UpdateCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.UpdateCheck_DoWork);
            this.UpdateCheck.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.UpdateCheck_RunWorkerCompleted);
            // 
            // DelayUpdateCheck
            // 
            this.DelayUpdateCheck.Interval = 2512;
            this.DelayUpdateCheck.Tick += new System.EventHandler(this.DelayUpdateCheck_Tick);
            // 
            // UpdateDotLX
            // 
            this.UpdateDotLX.Location = new System.Drawing.Point(327, 448);
            this.UpdateDotLX.Name = "UpdateDotLX";
            this.UpdateDotLX.Size = new System.Drawing.Size(117, 29);
            this.UpdateDotLX.TabIndex = 12;
            this.UpdateDotLX.Text = "Update Existing";
            this.UpdateDotLX.UseVisualStyleBackColor = true;
            this.UpdateDotLX.Click += new System.EventHandler(this.UpdateDotLX_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(296, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 230);
            this.panel2.TabIndex = 14;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Moxo_QuickWeb.Properties.Resources.DotLXLogo;
            this.pictureBox3.Location = new System.Drawing.Point(327, 264);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(240, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Moxo_QuickWeb.Properties.Resources._NETLogoMoxo;
            this.pictureBox2.Location = new System.Drawing.Point(28, 264);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::Moxo_QuickWeb.Properties.Resources.MoxoBackground_Color;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.UpdatePanel);
            this.panel1.Controls.Add(this.SettingManagement);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.Settings);
            this.panel1.Controls.Add(this.CheckForUpdates);
            this.panel1.Controls.Add(this.IssueReport);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 154);
            this.panel1.TabIndex = 0;
            // 
            // UpdatePanel
            // 
            this.UpdatePanel.BackColor = System.Drawing.Color.Transparent;
            this.UpdatePanel.Controls.Add(this.pictureBox5);
            this.UpdatePanel.Controls.Add(this.label6);
            this.UpdatePanel.Controls.Add(this.label5);
            this.UpdatePanel.Controls.Add(this.pictureBox1);
            this.UpdatePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdatePanel.Location = new System.Drawing.Point(337, 13);
            this.UpdatePanel.Name = "UpdatePanel";
            this.UpdatePanel.Size = new System.Drawing.Size(263, 71);
            this.UpdatePanel.TabIndex = 16;
            this.UpdatePanel.Visible = false;
            this.UpdatePanel.Click += new System.EventHandler(this.UpdatePanel_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Moxo_QuickWeb.Properties.Resources.WhiteSpace;
            this.pictureBox5.Location = new System.Drawing.Point(7, 64);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(246, 2);
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 30);
            this.label6.TabIndex = 16;
            this.label6.Text = "An update for Moxo QuickWeb Studio is available. Click here to update.";
            this.label6.Click += new System.EventHandler(this.UpdatePanel_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Updates Available";
            this.label5.Click += new System.EventHandler(this.UpdatePanel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Moxo_QuickWeb.Properties.Resources.CloudDownload;
            this.pictureBox1.Location = new System.Drawing.Point(214, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.UpdatePanel_Click);
            // 
            // SettingManagement
            // 
            this.SettingManagement.Location = new System.Drawing.Point(12, 13);
            this.SettingManagement.Name = "SettingManagement";
            this.SettingManagement.Size = new System.Drawing.Size(22, 15);
            this.SettingManagement.TabIndex = 15;
            this.SettingManagement.Text = "";
            this.SettingManagement.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Moxo_QuickWeb.Properties.Resources.MoxoQWSStacked;
            this.pictureBox4.Location = new System.Drawing.Point(15, 46);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(209, 95);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // Settings
            // 
            this.Settings.ActiveLinkColor = System.Drawing.Color.White;
            this.Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Settings.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Settings.LinkColor = System.Drawing.Color.White;
            this.Settings.Location = new System.Drawing.Point(370, 87);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(223, 19);
            this.Settings.TabIndex = 12;
            this.Settings.TabStop = true;
            this.Settings.Text = "Settings";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Settings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Settings_LinkClicked);
            // 
            // CheckForUpdates
            // 
            this.CheckForUpdates.ActiveLinkColor = System.Drawing.Color.White;
            this.CheckForUpdates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckForUpdates.BackColor = System.Drawing.Color.Transparent;
            this.CheckForUpdates.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.CheckForUpdates.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.CheckForUpdates.LinkColor = System.Drawing.Color.White;
            this.CheckForUpdates.Location = new System.Drawing.Point(367, 103);
            this.CheckForUpdates.Name = "CheckForUpdates";
            this.CheckForUpdates.Size = new System.Drawing.Size(226, 19);
            this.CheckForUpdates.TabIndex = 10;
            this.CheckForUpdates.TabStop = true;
            this.CheckForUpdates.Text = "Check for Updates";
            this.CheckForUpdates.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckForUpdates.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CheckForUpdates_LinkClicked);
            // 
            // IssueReport
            // 
            this.IssueReport.ActiveLinkColor = System.Drawing.Color.White;
            this.IssueReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IssueReport.BackColor = System.Drawing.Color.Transparent;
            this.IssueReport.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.IssueReport.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.IssueReport.LinkColor = System.Drawing.Color.White;
            this.IssueReport.Location = new System.Drawing.Point(373, 118);
            this.IssueReport.Name = "IssueReport";
            this.IssueReport.Size = new System.Drawing.Size(220, 19);
            this.IssueReport.TabIndex = 11;
            this.IssueReport.TabStop = true;
            this.IssueReport.Text = "Give Feedback or Report Issues";
            this.IssueReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IssueReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IssueReport_LinkClicked);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 532);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UpdateDotLX);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.DocsDotLX);
            this.Controls.Add(this.DocsDotNet);
            this.Controls.Add(this.StartDotLX);
            this.Controls.Add(this.StartDotNet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard | Moxo QuickWeb Studio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.UpdatePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button StartDotNet;
        private System.Windows.Forms.Button StartDotLX;
        private System.Windows.Forms.LinkLabel CheckForUpdates;
        private System.Windows.Forms.Button DocsDotNet;
        private System.Windows.Forms.Button DocsDotLX;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.LinkLabel IssueReport;
        private System.Windows.Forms.LinkLabel Settings;
        private System.Windows.Forms.PictureBox pictureBox4;
        public System.ComponentModel.BackgroundWorker UpdateCheck;
        private System.Windows.Forms.Timer DelayUpdateCheck;
        private System.Windows.Forms.Button UpdateDotLX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox SettingManagement;
        private System.Windows.Forms.Panel UpdatePanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}