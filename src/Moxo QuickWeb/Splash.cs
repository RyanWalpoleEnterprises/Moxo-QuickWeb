using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moxo_QuickWeb
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            string vertext  = "Version: " + Properties.Settings.Default.Version + "(" + Properties.Settings.Default.BuildVersion + ")";
            Version.Text = vertext;
            Properties.Settings.Default.dotLX_tmpICO = null;
            Properties.Settings.Default.Save();

            if (String.IsNullOrWhiteSpace(Properties.Settings.Default.LaunchArg))
            {
                CheckDirectories();
            }
            else
            {
                StartFileEditor.Start();
            }
        }

        private void CheckDirectories()
        {
            //Status.Text = "Validating directories...";

            string appdatadir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string userdatadir = appdatadir + @"\RWE\Moxo\QuickWeb\";
            string tmpdatafolder = userdatadir + @"tmp\";

            if (!Directory.Exists(userdatadir))
            {
                Directory.CreateDirectory(userdatadir);
            }

            if (Directory.Exists(tmpdatafolder))
            {
                Directory.Delete(tmpdatafolder, true);
            }

            if(File.Exists(userdatadir + @"settings.ini"))
            {
                Settings.LoadFile(userdatadir + @"settings.ini", RichTextBoxStreamType.PlainText);
                foreach(string line in Settings.Lines)
                {
                    if (line.StartsWith("$CheckUpdatesOnStartup=")) { Properties.Settings.Default.CheckUpdate = line.Replace("$CheckUpdatesOnStartup=",null); }
                    Properties.Settings.Default.Save();
                }
            }
            else
            {
                Settings.AppendText("$CheckUpdatesOnStartup=" + Properties.Settings.Default.CheckUpdate);
                Settings.SaveFile(userdatadir + @"settings.ini", RichTextBoxStreamType.PlainText);
            }

            //Status.Text = "Starting QuickWeb Studio...";
            StartApplication.Start();
        }

        private void StartApplication_Tick(object sender, EventArgs e)
        {
            StartApplication.Stop();

            Dashboard endpoint = new Dashboard();
            endpoint.Show();
            this.Hide();
        }

        private void StartFileEditor_Tick(object sender, EventArgs e)
        {
            StartFileEditor.Stop();

            LXEditor endpoint = new LXEditor();
            endpoint.Show();
            this.Hide();
        }
    }
}
