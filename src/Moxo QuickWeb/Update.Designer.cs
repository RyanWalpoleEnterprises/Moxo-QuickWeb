namespace Moxo_QuickWeb
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.DownloadProgress = new System.Windows.Forms.Label();
            this.StatusText = new System.Windows.Forms.Label();
            this.StartExecute = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(25, 133);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(361, 23);
            this.ProgressBar.TabIndex = 0;
            // 
            // DownloadProgress
            // 
            this.DownloadProgress.AutoSize = true;
            this.DownloadProgress.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DownloadProgress.Location = new System.Drawing.Point(22, 108);
            this.DownloadProgress.Name = "DownloadProgress";
            this.DownloadProgress.Size = new System.Drawing.Size(74, 13);
            this.DownloadProgress.TabIndex = 1;
            this.DownloadProgress.Text = "Calculating...";
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F);
            this.StatusText.Location = new System.Drawing.Point(21, 85);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(96, 20);
            this.StatusText.TabIndex = 3;
            this.StatusText.Text = "Please wait...";
            // 
            // StartExecute
            // 
            this.StartExecute.Interval = 3000;
            this.StartExecute.Tick += new System.EventHandler(this.StartExecute_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Moxo_QuickWeb.Properties.Resources.MoxoQWSColorLogo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(408, 180);
            this.ControlBox = false;
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DownloadProgress);
            this.Controls.Add(this.ProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Software Update | Moxo QuickWeb Studio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label DownloadProgress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.Timer StartExecute;
    }
}