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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Settings = new System.Windows.Forms.LinkLabel();
            this.CheckForUpdates = new System.Windows.Forms.LinkLabel();
            this.IssueReport = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label1.Location = new System.Drawing.Point(19, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turn your web-application into a Windows Desktop application with .NET that can b" +
    "e edited and expanded upon with Visual Studio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label2.Location = new System.Drawing.Point(297, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 77);
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
            this.label3.Text = "Create a Web-App";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label4.Location = new System.Drawing.Point(13, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(538, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select a project type from the available types below:";
            // 
            // StartDotNet
            // 
            this.StartDotNet.Location = new System.Drawing.Point(28, 420);
            this.StartDotNet.Name = "StartDotNet";
            this.StartDotNet.Size = new System.Drawing.Size(104, 29);
            this.StartDotNet.TabIndex = 7;
            this.StartDotNet.Text = "Get Started";
            this.StartDotNet.UseVisualStyleBackColor = true;
            this.StartDotNet.Click += new System.EventHandler(this.StartDotNet_Click);
            // 
            // StartDotLX
            // 
            this.StartDotLX.Location = new System.Drawing.Point(297, 420);
            this.StartDotLX.Name = "StartDotLX";
            this.StartDotLX.Size = new System.Drawing.Size(104, 29);
            this.StartDotLX.TabIndex = 8;
            this.StartDotLX.Text = "Get Started";
            this.StartDotLX.UseVisualStyleBackColor = true;
            this.StartDotLX.Click += new System.EventHandler(this.StartDotLX_Click);
            // 
            // DocsDotNet
            // 
            this.DocsDotNet.Location = new System.Drawing.Point(138, 420);
            this.DocsDotNet.Name = "DocsDotNet";
            this.DocsDotNet.Size = new System.Drawing.Size(103, 29);
            this.DocsDotNet.TabIndex = 9;
            this.DocsDotNet.Text = "Documentation";
            this.DocsDotNet.UseVisualStyleBackColor = true;
            this.DocsDotNet.Click += new System.EventHandler(this.DocsDotNet_Click);
            // 
            // DocsDotLX
            // 
            this.DocsDotLX.Location = new System.Drawing.Point(407, 420);
            this.DocsDotLX.Name = "DocsDotLX";
            this.DocsDotLX.Size = new System.Drawing.Size(103, 29);
            this.DocsDotLX.TabIndex = 10;
            this.DocsDotLX.Text = "Documentation";
            this.DocsDotLX.UseVisualStyleBackColor = true;
            this.DocsDotLX.Click += new System.EventHandler(this.DocsDotLX_Click);
            // 
            // Version
            // 
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Version.ForeColor = System.Drawing.Color.Gray;
            this.Version.Location = new System.Drawing.Point(6, 473);
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
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Moxo_QuickWeb.Properties.Resources.DotLXLogo;
            this.pictureBox3.Location = new System.Drawing.Point(297, 262);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(213, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Moxo_QuickWeb.Properties.Resources._NETLogoMoxo;
            this.pictureBox2.Location = new System.Drawing.Point(28, 262);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Moxo_QuickWeb.Properties.Resources.MoxoBackground_Color;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.Settings);
            this.panel1.Controls.Add(this.CheckForUpdates);
            this.panel1.Controls.Add(this.IssueReport);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 154);
            this.panel1.TabIndex = 0;
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
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Settings.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Settings.LinkColor = System.Drawing.Color.White;
            this.Settings.Location = new System.Drawing.Point(317, 87);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(223, 19);
            this.Settings.TabIndex = 12;
            this.Settings.TabStop = true;
            this.Settings.Text = "Settings";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Settings.Visible = false;
            // 
            // CheckForUpdates
            // 
            this.CheckForUpdates.ActiveLinkColor = System.Drawing.Color.White;
            this.CheckForUpdates.BackColor = System.Drawing.Color.Transparent;
            this.CheckForUpdates.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.CheckForUpdates.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.CheckForUpdates.LinkColor = System.Drawing.Color.White;
            this.CheckForUpdates.Location = new System.Drawing.Point(314, 103);
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
            this.IssueReport.BackColor = System.Drawing.Color.Transparent;
            this.IssueReport.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.IssueReport.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.IssueReport.LinkColor = System.Drawing.Color.White;
            this.IssueReport.Location = new System.Drawing.Point(320, 118);
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
            this.ClientSize = new System.Drawing.Size(545, 498);
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
    }
}