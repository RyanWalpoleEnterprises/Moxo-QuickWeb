namespace Moxo_QuickWeb
{
    partial class UserSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettings));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveSettings = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Checkbox_CheckUpdatesOnStartup = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 34);
            this.label2.TabIndex = 39;
            this.label2.Text = "If checked, Moxo QuickWeb Studio will perform an automatic update check whenever " +
    "you open the application.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Check for Updates on Startup";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Moxo_QuickWeb.Properties.Resources.MoxoBackground_Color;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-34, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 48);
            this.panel1.TabIndex = 41;
            // 
            // SaveSettings
            // 
            this.SaveSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SaveSettings.Location = new System.Drawing.Point(206, 151);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.Size = new System.Drawing.Size(124, 28);
            this.SaveSettings.TabIndex = 40;
            this.SaveSettings.Text = "Save and Close";
            this.SaveSettings.UseVisualStyleBackColor = true;
            this.SaveSettings.Click += new System.EventHandler(this.SaveSettings_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Cancel.Location = new System.Drawing.Point(120, 151);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(80, 28);
            this.Cancel.TabIndex = 42;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Checkbox_CheckUpdatesOnStartup
            // 
            this.Checkbox_CheckUpdatesOnStartup.AutoSize = true;
            this.Checkbox_CheckUpdatesOnStartup.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Checkbox_CheckUpdatesOnStartup.Location = new System.Drawing.Point(15, 82);
            this.Checkbox_CheckUpdatesOnStartup.Name = "Checkbox_CheckUpdatesOnStartup";
            this.Checkbox_CheckUpdatesOnStartup.Size = new System.Drawing.Size(61, 17);
            this.Checkbox_CheckUpdatesOnStartup.TabIndex = 43;
            this.Checkbox_CheckUpdatesOnStartup.Text = "Enable";
            this.Checkbox_CheckUpdatesOnStartup.UseVisualStyleBackColor = true;
            this.Checkbox_CheckUpdatesOnStartup.CheckedChanged += new System.EventHandler(this.Checkbox_CheckUpdatesOnStartup_CheckedChanged);
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 188);
            this.Controls.Add(this.Checkbox_CheckUpdatesOnStartup);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Settings | Moxo QuickWeb Studio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveSettings;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.CheckBox Checkbox_CheckUpdatesOnStartup;
    }
}