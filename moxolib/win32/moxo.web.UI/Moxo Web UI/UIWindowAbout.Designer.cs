namespace Moxo_Web_UI
{
    partial class UIWindowAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIWindowAbout));
            this.UI_AboutHeadings = new System.Windows.Forms.Label();
            this.UI_AboutData = new System.Windows.Forms.Label();
            this.UI_Label_MoxoDisc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UI_LinkButton_Moxo = new System.Windows.Forms.LinkLabel();
            this.UI_Button_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_AboutHeadings
            // 
            this.UI_AboutHeadings.AutoSize = true;
            this.UI_AboutHeadings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_AboutHeadings.Location = new System.Drawing.Point(12, 21);
            this.UI_AboutHeadings.Name = "UI_AboutHeadings";
            this.UI_AboutHeadings.Size = new System.Drawing.Size(71, 60);
            this.UI_AboutHeadings.TabIndex = 0;
            this.UI_AboutHeadings.Text = "Application:\r\nDeveloper:\r\nPublisher:\r\nVersion:";
            // 
            // UI_AboutData
            // 
            this.UI_AboutData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UI_AboutData.Location = new System.Drawing.Point(94, 21);
            this.UI_AboutData.Name = "UI_AboutData";
            this.UI_AboutData.Size = new System.Drawing.Size(246, 60);
            this.UI_AboutData.TabIndex = 1;
            this.UI_AboutData.Text = "Example\r\nExample\r\nExample\r\nExample";
            // 
            // UI_Label_MoxoDisc
            // 
            this.UI_Label_MoxoDisc.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.UI_Label_MoxoDisc.Location = new System.Drawing.Point(20, 171);
            this.UI_Label_MoxoDisc.Name = "UI_Label_MoxoDisc";
            this.UI_Label_MoxoDisc.Size = new System.Drawing.Size(172, 42);
            this.UI_Label_MoxoDisc.TabIndex = 2;
            this.UI_Label_MoxoDisc.Text = "This application was built with Moxo-QuickWeb.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Moxo_Web_UI.Properties.Resources.MoxoLogoFull_1024x433;
            this.pictureBox1.Location = new System.Drawing.Point(13, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // UI_LinkButton_Moxo
            // 
            this.UI_LinkButton_Moxo.AutoSize = true;
            this.UI_LinkButton_Moxo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.UI_LinkButton_Moxo.Location = new System.Drawing.Point(112, 184);
            this.UI_LinkButton_Moxo.Name = "UI_LinkButton_Moxo";
            this.UI_LinkButton_Moxo.Size = new System.Drawing.Size(65, 13);
            this.UI_LinkButton_Moxo.TabIndex = 4;
            this.UI_LinkButton_Moxo.TabStop = true;
            this.UI_LinkButton_Moxo.Text = "Learn More";
            this.UI_LinkButton_Moxo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UI_LinkButton_Moxo_LinkClicked);
            // 
            // UI_Button_Close
            // 
            this.UI_Button_Close.Location = new System.Drawing.Point(248, 174);
            this.UI_Button_Close.Name = "UI_Button_Close";
            this.UI_Button_Close.Size = new System.Drawing.Size(92, 23);
            this.UI_Button_Close.TabIndex = 5;
            this.UI_Button_Close.Text = "Close";
            this.UI_Button_Close.UseVisualStyleBackColor = true;
            this.UI_Button_Close.Click += new System.EventHandler(this.UI_Button_Close_Click);
            // 
            // UIWindowAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 217);
            this.Controls.Add(this.UI_Button_Close);
            this.Controls.Add(this.UI_LinkButton_Moxo);
            this.Controls.Add(this.UI_Label_MoxoDisc);
            this.Controls.Add(this.UI_AboutData);
            this.Controls.Add(this.UI_AboutHeadings);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UIWindowAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About - moxolib.userdefined.ApplicationName";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_AboutHeadings;
        private System.Windows.Forms.Label UI_AboutData;
        private System.Windows.Forms.Label UI_Label_MoxoDisc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel UI_LinkButton_Moxo;
        private System.Windows.Forms.Button UI_Button_Close;
    }
}