using Syncfusion.Windows.Forms.Edit.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moxo_QuickWeb
{
    public partial class LXEditor : Form
    {
        public LXEditor()
        {
            InitializeComponent();

            this.Editor.LoadFile(Path.GetFullPath(Properties.Settings.Default.LaunchArg));
            this.Editor.ApplyConfiguration(Syncfusion.Windows.Forms.Edit.Enums.KnownLanguages.CSharp);
            this.Editor.StatusBarSettings.Visible = true;

            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Editor.Save();
        }

        private void LXEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            bool canUndo = this.Editor.CanUndo;
            if(canUndo == true)
            {
                this.Editor.Undo();
            }
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            bool canRedo = this.Editor.CanUndo;
            if (canRedo == true)
            {
                this.Editor.Redo();
            }
        }
    }
}
