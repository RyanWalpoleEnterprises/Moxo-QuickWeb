namespace Moxo_QuickWeb
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Status = new System.Windows.Forms.Label();
            this.StartApplication = new System.Windows.Forms.Timer(this.components);
            this.Version = new System.Windows.Forms.Label();
            this.StartFileEditor = new System.Windows.Forms.Timer(this.components);
            this.Settings = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Moxo_QuickWeb.Properties.Resources.MoxoQWSWhiteFullLogo;
            this.pictureBox1.Location = new System.Drawing.Point(1, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Moxo_QuickWeb.Properties.Resources.RWE_logo_White;
            this.pictureBox3.Location = new System.Drawing.Point(453, 218);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Transparent;
            this.Status.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.Location = new System.Drawing.Point(0, 154);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(559, 23);
            this.Status.TabIndex = 3;
            this.Status.Text = "Starting QuickWeb ...";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartApplication
            // 
            this.StartApplication.Interval = 3000;
            this.StartApplication.Tick += new System.EventHandler(this.StartApplication_Tick);
            // 
            // Version
            // 
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.Version.ForeColor = System.Drawing.Color.White;
            this.Version.Location = new System.Drawing.Point(12, 235);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(313, 23);
            this.Version.TabIndex = 4;
            this.Version.Text = "Version: ";
            this.Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StartFileEditor
            // 
            this.StartFileEditor.Interval = 2512;
            this.StartFileEditor.Tick += new System.EventHandler(this.StartFileEditor_Tick);
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(12, 12);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(71, 32);
            this.Settings.TabIndex = 5;
            this.Settings.Text = "";
            this.Settings.Visible = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Moxo_QuickWeb.Properties.Resources.MoxoBackground_Color;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 267);
            this.ControlBox = false;
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moxo QuickWeb";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Timer StartApplication;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Timer StartFileEditor;
        private System.Windows.Forms.RichTextBox Settings;
    }
}

