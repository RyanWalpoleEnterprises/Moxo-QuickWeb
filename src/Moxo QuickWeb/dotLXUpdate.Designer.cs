namespace Moxo_QuickWeb
{
    partial class dotLXUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dotLXUpdate));
            this.AppDirectoryPath = new System.Windows.Forms.TextBox();
            this.BrowseToDirectory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MoxoVer = new System.Windows.Forms.RichTextBox();
            this.ListFiles = new System.Windows.Forms.RichTextBox();
            this.Overview = new System.Windows.Forms.GroupBox();
            this.AppName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProgramCLX = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AppVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FrameworkVer = new System.Windows.Forms.Label();
            this.UpdateDetails = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.ApplyUpdate = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Overview.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppDirectoryPath
            // 
            this.AppDirectoryPath.Enabled = false;
            this.AppDirectoryPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AppDirectoryPath.Location = new System.Drawing.Point(15, 97);
            this.AppDirectoryPath.Name = "AppDirectoryPath";
            this.AppDirectoryPath.Size = new System.Drawing.Size(328, 23);
            this.AppDirectoryPath.TabIndex = 1;
            this.AppDirectoryPath.TextChanged += new System.EventHandler(this.AppDirectoryPath_TextChanged);
            // 
            // BrowseToDirectory
            // 
            this.BrowseToDirectory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BrowseToDirectory.Location = new System.Drawing.Point(349, 97);
            this.BrowseToDirectory.Name = "BrowseToDirectory";
            this.BrowseToDirectory.Size = new System.Drawing.Size(73, 23);
            this.BrowseToDirectory.TabIndex = 2;
            this.BrowseToDirectory.Text = "Browse";
            this.BrowseToDirectory.UseVisualStyleBackColor = true;
            this.BrowseToDirectory.Click += new System.EventHandler(this.BrowseToDirectory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Where is your application saved?";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Click \"Browse\" and select your application that you wish to update.";
            // 
            // MoxoVer
            // 
            this.MoxoVer.Location = new System.Drawing.Point(366, 49);
            this.MoxoVer.Name = "MoxoVer";
            this.MoxoVer.Size = new System.Drawing.Size(56, 25);
            this.MoxoVer.TabIndex = 5;
            this.MoxoVer.Text = "";
            this.MoxoVer.Visible = false;
            this.MoxoVer.TextChanged += new System.EventHandler(this.MoxoVer_TextChanged);
            // 
            // ListFiles
            // 
            this.ListFiles.Location = new System.Drawing.Point(305, 47);
            this.ListFiles.Name = "ListFiles";
            this.ListFiles.Size = new System.Drawing.Size(55, 25);
            this.ListFiles.TabIndex = 6;
            this.ListFiles.Text = "";
            this.ListFiles.Visible = false;
            // 
            // Overview
            // 
            this.Overview.Controls.Add(this.Close);
            this.Overview.Controls.Add(this.ApplyUpdate);
            this.Overview.Controls.Add(this.Label30);
            this.Overview.Controls.Add(this.UpdateDetails);
            this.Overview.Controls.Add(this.FrameworkVer);
            this.Overview.Controls.Add(this.label3);
            this.Overview.Controls.Add(this.AppVersion);
            this.Overview.Controls.Add(this.label5);
            this.Overview.Controls.Add(this.label4);
            this.Overview.Controls.Add(this.AppName);
            this.Overview.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Overview.Location = new System.Drawing.Point(15, 138);
            this.Overview.Name = "Overview";
            this.Overview.Size = new System.Drawing.Size(407, 251);
            this.Overview.TabIndex = 7;
            this.Overview.TabStop = false;
            this.Overview.Text = "Overview";
            this.Overview.Visible = false;
            // 
            // AppName
            // 
            this.AppName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AppName.Location = new System.Drawing.Point(134, 32);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(222, 16);
            this.AppName.TabIndex = 8;
            this.AppName.Text = "AppName.Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Application Name";
            // 
            // ProgramCLX
            // 
            this.ProgramCLX.Location = new System.Drawing.Point(244, 47);
            this.ProgramCLX.Name = "ProgramCLX";
            this.ProgramCLX.Size = new System.Drawing.Size(55, 25);
            this.ProgramCLX.TabIndex = 8;
            this.ProgramCLX.Text = "";
            this.ProgramCLX.Visible = false;
            this.ProgramCLX.TextChanged += new System.EventHandler(this.ProgramCLX_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Application Version";
            // 
            // AppVersion
            // 
            this.AppVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AppVersion.Location = new System.Drawing.Point(134, 51);
            this.AppVersion.Name = "AppVersion";
            this.AppVersion.Size = new System.Drawing.Size(222, 16);
            this.AppVersion.TabIndex = 10;
            this.AppVersion.Text = "AppName.Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Framework Version";
            // 
            // FrameworkVer
            // 
            this.FrameworkVer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FrameworkVer.Location = new System.Drawing.Point(134, 70);
            this.FrameworkVer.Name = "FrameworkVer";
            this.FrameworkVer.Size = new System.Drawing.Size(222, 16);
            this.FrameworkVer.TabIndex = 12;
            this.FrameworkVer.Text = "AppName.Text";
            // 
            // UpdateDetails
            // 
            this.UpdateDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateDetails.Location = new System.Drawing.Point(8, 140);
            this.UpdateDetails.Name = "UpdateDetails";
            this.UpdateDetails.Size = new System.Drawing.Size(383, 59);
            this.UpdateDetails.TabIndex = 13;
            this.UpdateDetails.Text = "Determining if your application is up to date...";
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.Label30.Location = new System.Drawing.Point(8, 121);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(84, 15);
            this.Label30.TabIndex = 14;
            this.Label30.Text = "Update Details";
            // 
            // ApplyUpdate
            // 
            this.ApplyUpdate.Enabled = false;
            this.ApplyUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ApplyUpdate.Location = new System.Drawing.Point(290, 210);
            this.ApplyUpdate.Name = "ApplyUpdate";
            this.ApplyUpdate.Size = new System.Drawing.Size(101, 28);
            this.ApplyUpdate.TabIndex = 15;
            this.ApplyUpdate.Text = "Update";
            this.ApplyUpdate.UseVisualStyleBackColor = true;
            this.ApplyUpdate.Click += new System.EventHandler(this.ApplyUpdate_Click);
            // 
            // Close
            // 
            this.Close.Enabled = false;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Close.Location = new System.Drawing.Point(183, 210);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(101, 28);
            this.Close.TabIndex = 16;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Moxo_QuickWeb.Properties.Resources.MoxoBackground_Color;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-4, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 48);
            this.panel1.TabIndex = 36;
            // 
            // dotLXUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 398);
            this.Controls.Add(this.ProgramCLX);
            this.Controls.Add(this.Overview);
            this.Controls.Add(this.ListFiles);
            this.Controls.Add(this.MoxoVer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowseToDirectory);
            this.Controls.Add(this.AppDirectoryPath);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "dotLXUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Your Application | Moxo QuickWeb Studio for dotLX";
            this.Overview.ResumeLayout(false);
            this.Overview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AppDirectoryPath;
        private System.Windows.Forms.Button BrowseToDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox MoxoVer;
        private System.Windows.Forms.RichTextBox ListFiles;
        private System.Windows.Forms.GroupBox Overview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.RichTextBox ProgramCLX;
        private System.Windows.Forms.Label AppVersion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Label30;
        private System.Windows.Forms.Label UpdateDetails;
        private System.Windows.Forms.Label FrameworkVer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button ApplyUpdate;
        private System.Windows.Forms.Panel panel1;
    }
}