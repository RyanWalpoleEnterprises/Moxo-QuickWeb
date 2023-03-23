namespace Moxo_QuickWeb
{
    partial class LXEditor
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
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LXEditor));
            this.Editor = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.Undo = new System.Windows.Forms.ToolStripButton();
            this.Redo = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Editor
            // 
            this.Editor.AllowZoom = false;
            this.Editor.AlwaysShowScrollers = true;
            this.Editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Editor.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart;
            this.Editor.ChangedLinesMarkingLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(98)))));
            this.Editor.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.Editor.Configurator = config1;
            this.Editor.ContextChoiceBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Editor.ContextChoiceBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(50)))));
            this.Editor.ContextChoiceForeColor = System.Drawing.SystemColors.InfoText;
            this.Editor.ContextMenuEnabled = false;
            this.Editor.ContextPromptBackgroundBrush = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.Editor.ContextTooltipBackgroundBrush = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(232)))), ((int)(((byte)(236))))));
            this.Editor.EnableBlockSelection = true;
            this.Editor.FileExtensions = new string[] {
        ".clx",
        ".lx"};
            this.Editor.GraphicsCompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.Editor.GraphicsSmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.Editor.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.Editor.LikeVisualStudioSearch = true;
            this.Editor.LineNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Editor.Location = new System.Drawing.Point(0, 43);
            this.Editor.Name = "Editor";
            this.Editor.RenderRightToLeft = false;
            this.Editor.ScrollPosition = new System.Drawing.Point(0, 0);
            this.Editor.ScrollVisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2016;
            this.Editor.SelectionMode = Syncfusion.Windows.Forms.Edit.SelectionModes.Block;
            this.Editor.SelectionTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.Editor.ShowEndOfLine = false;
            this.Editor.ShowHorizontalSplitters = false;
            this.Editor.ShowVerticalSplitters = false;
            this.Editor.Size = new System.Drawing.Size(964, 517);
            this.Editor.StatusBarSettings.CoordsPanel.Width = 150;
            this.Editor.StatusBarSettings.EncodingPanel.Width = 100;
            this.Editor.StatusBarSettings.FileNamePanel.Width = 100;
            this.Editor.StatusBarSettings.GripVisibility = Syncfusion.Windows.Forms.Edit.Enums.SizingGripVisibility.Hidden;
            this.Editor.StatusBarSettings.InsertPanel.Width = 33;
            this.Editor.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.Editor.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.Editor.StatusBarSettings.StatusPanel.Width = 70;
            this.Editor.StatusBarSettings.TextPanel.Width = 166;
            this.Editor.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Office2016Colorful;
            this.Editor.Style = Syncfusion.Windows.Forms.Edit.EditControlStyle.Office2016Colorful;
            this.Editor.TabIndex = 0;
            this.Editor.Text = "";
            this.Editor.ThemeName = "Office2016Colorful";
            this.Editor.UseXPStyle = false;
            this.Editor.UseXPStyleBorder = false;
            this.Editor.VisualColumn = 1;
            this.Editor.VScrollMode = Syncfusion.Windows.Forms.Edit.ScrollMode.Immediate;
            this.Editor.ZoomFactor = 1F;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save,
            this.Undo,
            this.Redo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(964, 47);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Save
            // 
            this.Save.AutoSize = false;
            this.Save.Image = global::Moxo_QuickWeb.Properties.Resources.Save;
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Margin = new System.Windows.Forms.Padding(15, 5, 0, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(50, 38);
            this.Save.Text = "Save";
            this.Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Undo
            // 
            this.Undo.AutoSize = false;
            this.Undo.Image = global::Moxo_QuickWeb.Properties.Resources.Undo;
            this.Undo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Undo.Margin = new System.Windows.Forms.Padding(0, 5, 0, 4);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(50, 38);
            this.Undo.Text = "Undo";
            this.Undo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Redo
            // 
            this.Redo.AutoSize = false;
            this.Redo.Image = global::Moxo_QuickWeb.Properties.Resources.Redo;
            this.Redo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Redo.Margin = new System.Windows.Forms.Padding(0, 5, 0, 4);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(50, 38);
            this.Redo.Text = "Redo";
            this.Redo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            // 
            // LXEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 560);
            this.Controls.Add(this.Editor);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LXEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dotLX Editor (Mini) | Moxo QuickWeb Studio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LXEditor_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Editor)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Edit.EditControl Editor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripButton Undo;
        private System.Windows.Forms.ToolStripButton Redo;
    }
}