using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moxo_QuickWeb
{
    public partial class UserSettings : Form
    {
        public UserSettings()
        {
            InitializeComponent();

            //Load Settings
            if(Properties.Settings.Default.CheckUpdate == "TRUE")
            {
                Checkbox_CheckUpdatesOnStartup.Checked = true;
            }
            else if (Properties.Settings.Default.CheckUpdate == "FALSE")
            {
                Checkbox_CheckUpdatesOnStartup.Checked = false;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Checkbox_CheckUpdatesOnStartup_CheckedChanged(object sender, EventArgs e)
        {
            if(Checkbox_CheckUpdatesOnStartup.Checked == true)
            {
                Properties.Settings.Default.CheckUpdate = "TRUE";
            }
            else if (Checkbox_CheckUpdatesOnStartup.Checked == false)
            {
                Properties.Settings.Default.CheckUpdate = "FALSE";
            }
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
