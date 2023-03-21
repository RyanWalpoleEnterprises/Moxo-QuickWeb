using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moxo_QuickWeb
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            Version.Text = "Version: " + Properties.Settings.Default.Version + "(" + Properties.Settings.Default.BuildVersion + ")";

            if(Properties.Settings.Default.CheckUpdate == "TRUE")
            {
                UpdateCheck.RunWorkerAsync();
            }
        }

        private void CheckForUpdates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                CheckForUpdates.Text = "Checking for updates...";
                string CurrentUpdateVersion = "https://raw.githubusercontent.com/RyanWalpoleEnterprises/Moxo-QuickWeb/main/installer/cver.txt";

                //View current stable version number
                WebClient client = new WebClient();
                client.Proxy = null;
                Stream stream = client.OpenRead(CurrentUpdateVersion);
                StreamReader reader = new StreamReader(stream);
                String CVER = reader.ReadToEnd();

                if (CVER.Contains(Properties.Settings.Default.Version))
                {
                    Properties.Settings.Default.UpdateReady = "FALSE";
                }
                else if (!CVER.Contains(Properties.Settings.Default.Version))
                {
                    Properties.Settings.Default.UpdateReady = "TRUE";
                    CheckForUpdates.Text = "Updates available";
                    DialogResult result = MessageBox.Show("Moxo QuickWeb Studio has available updates. Would you like to download and install these updates now?", "Moxo QuickWeb Studio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        Update update = new Update();
                        update.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        //
                    }
                }
            }
            catch
            {

            }
        }

        private void StartDotNet_Click(object sender, EventArgs e)
        {
            NewDotNET newproject = new NewDotNET();
            newproject.Show();
            this.Hide();
        }

        private void DocsDotNet_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/RyanWalpoleEnterprises/Moxo-QuickWeb/wiki/QuickWeb-.NET");
        }

        private void DocsDotLX_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/RyanWalpoleEnterprises/Moxo-QuickWeb/wiki/QuickWeb-dotLX");
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void StartDotLX_Click(object sender, EventArgs e)
        {
            NewdotLX newproject = new NewdotLX();
            newproject.Show();
            this.Hide();
        }

        private void UpdateCheck_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForUpdates.Text = "Checking for updates...";
            string CurrentUpdateVersion = "https://raw.githubusercontent.com/RyanWalpoleEnterprises/Moxo-QuickWeb/main/installer/cver.txt";

            //View current stable version number
            WebClient client = new WebClient();
            client.Proxy = null;
            Stream stream = client.OpenRead(CurrentUpdateVersion);
            StreamReader reader = new StreamReader(stream);
            String CVER = reader.ReadToEnd();

            if (CVER.Contains(Properties.Settings.Default.Version))
            {
                Properties.Settings.Default.UpdateReady = "FALSE";
            }
            else if(!CVER.Contains(Properties.Settings.Default.Version))
            {
                Properties.Settings.Default.UpdateReady = "TRUE";
            }
        }

        private void UpdateCheck_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(Properties.Settings.Default.UpdateReady == "TRUE")
            {
                CheckForUpdates.Text = "Updates available";
                DialogResult result = MessageBox.Show("Moxo QuickWeb Studio has available updates. Would you like to download and install these updates now?", "Moxo QuickWeb Studio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Update update = new Update();
                    update.ShowDialog();
                    this.Hide();
                }
                else
                {
                    //
                }
            }
            else if(Properties.Settings.Default.UpdateReady == "FALSE")
            {
                CheckForUpdates.Text = "No updates available";
            }
        }

        private void IssueReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/RyanWalpoleEnterprises/Moxo-QuickWeb/issues");
        }
    }
}
