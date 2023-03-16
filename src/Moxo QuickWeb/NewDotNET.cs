using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Moxo_QuickWeb
{
    public partial class NewDotNET : Form
    {
        public NewDotNET()
        {
            string appdatadir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string userdatadir = appdatadir + @"\RWE\Moxo\QuickWeb\";
            string tmpdatafolder = userdatadir + @"tmp\";
            string propertiesdir = tmpdatafolder + @"\Moxo Web UI\Properties\";
            string appconfig = tmpdatafolder + @"\Moxo Web UI\App.config";

            string source = @"C:\Program Files (x86)\RWE\Moxo\QuickWeb\blankproj.zip";
            string dest = tmpdatafolder;

            if (!Directory.Exists(tmpdatafolder))
            {
                Directory.CreateDirectory(tmpdatafolder);
            }

            ZipFile.ExtractToDirectory(source, dest);

            InitializeComponent();

            SettingsSettings.LoadFile(propertiesdir + @"Settings.settings", RichTextBoxStreamType.PlainText);
            SettingsVisual.LoadFile(propertiesdir + @"Settings.Designer.cs", RichTextBoxStreamType.PlainText);
            Assembly.LoadFile(propertiesdir + @"AssemblyInfo.cs", RichTextBoxStreamType.PlainText);
            //AppConfig.LoadFile(appconfig, RichTextBoxStreamType.PlainText);
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            string appdatadir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string userdatadir = appdatadir + @"\RWE\Moxo\QuickWeb\";
            string tmpdatafolder = userdatadir + @"tmp\";
            string propertiesdir = tmpdatafolder + @"\Moxo Web UI\Properties\";
            string appconfig = tmpdatafolder + @"\Moxo Web UI\App.config";

            ContinueButton.Text = "Loading...";
            ContinueButton.Enabled = false;
            CancelButton.Enabled = false;

            if (ApplicationName.Text == null) { ApplicationName.Text = "Moxo QuickWeb App"; }
            if (ApplicationVersion.Text == null) { ApplicationVersion.Text = "1.0"; }
            if (ApplicationPublisher.Text == null) { ApplicationPublisher.Text = "Publisher"; }
            if (ApplicationDeveloper.Text == null) { ApplicationDeveloper.Text = "Developer"; }
            if (ApplicationWebViewSource.Text == null) { ApplicationWebViewSource.Text = "https://www.ryanwalpole.com/developer/moxo/qws/example"; }
            if (ApplicationWindowHeight.Text == null) { ApplicationWindowHeight.Text = "800"; }
            if (ApplicationWindowWidth.Text == null) { ApplicationWindowWidth.Text = "800"; }

            if (!ApplicationWebViewSource.Text.StartsWith("https://"))
            {
                if (ApplicationWebViewSource.Text.StartsWith("http://"))
                {
                    //Starts with HTTP
                }
                else
                {
                    ApplicationWebViewSource.Text = "https://" + ApplicationWebViewSource.Text;
                }
            }

            string AppName = ApplicationName.Text;
            string Version = ApplicationVersion.Text;
            string Publisher = ApplicationPublisher.Text;
            string Developer = ApplicationDeveloper.Text;

            string URL = ApplicationWebViewSource.Text;
            string Height = ApplicationWindowHeight.Text;
            string Width = ApplicationWindowWidth.Text;

            //Save AssemblyInfo
            Assembly.Text = Assembly.Text.Replace("moxolib.userdefined.AssemblyAppName",AppName);
            Assembly.Text = Assembly.Text.Replace("moxolib.userdefined.AssemblyAppDescription", AppName + "by " + Developer);
            Assembly.Text = Assembly.Text.Replace("moxolib.userdefined.AssemblyCompany", Developer + ", " + Publisher);
            Assembly.SaveFile(propertiesdir + @"AssemblyInfo.cs", RichTextBoxStreamType.PlainText);

            //Save Settings.Designer
            SettingsVisual.Text = SettingsVisual.Text.Replace("moxolib.userdefined.DeveloperName", Developer);
            SettingsVisual.Text = SettingsVisual.Text.Replace("moxolib.userdefined.PublisherName", Publisher);
            SettingsVisual.Text = SettingsVisual.Text.Replace("moxolib.userdefined.ApplicationVersion", Version);
            SettingsVisual.Text = SettingsVisual.Text.Replace("moxolib.userdefined.ApplicationName", AppName);
            SettingsVisual.Text = SettingsVisual.Text.Replace("moxolib.userdefined.WebViewSource", URL);
            SettingsVisual.Text = SettingsVisual.Text.Replace("1234567890", Height);
            SettingsVisual.Text = SettingsVisual.Text.Replace("9876543210", Width);
            SettingsVisual.SaveFile(propertiesdir + @"Settings.Designer.cs", RichTextBoxStreamType.PlainText);

            //Save App.Config
            AppConfig.Text = SettingsVisual.Text.Replace("moxolib.userdefined.DeveloperName", Developer);
            AppConfig.Text = SettingsVisual.Text.Replace("moxolib.userdefined.PublisherName", Publisher);
            AppConfig.Text = SettingsVisual.Text.Replace("moxolib.userdefined.ApplicationVersion", Version);
            AppConfig.Text = SettingsVisual.Text.Replace("moxolib.userdefined.ApplicationName", AppName);
            AppConfig.Text = SettingsVisual.Text.Replace("moxolib.userdefined.WebViewSource", URL);
            AppConfig.Text = SettingsVisual.Text.Replace("1234567890", Height);
            AppConfig.Text = SettingsVisual.Text.Replace("9876543210", Width);
            //AppConfig.SaveFile(appconfig, RichTextBoxStreamType.PlainText);

            //Save Settings.Settings
            SettingsSettings.Text = SettingsSettings.Text.Replace("moxolib.userdefined.DeveloperName", Developer);
            SettingsSettings.Text = SettingsSettings.Text.Replace("moxolib.userdefined.PublisherName", Publisher);
            SettingsSettings.Text = SettingsSettings.Text.Replace("moxolib.userdefined.ApplicationVersion", Version);
            SettingsSettings.Text = SettingsSettings.Text.Replace("moxolib.userdefined.ApplicationName", AppName);
            SettingsSettings.Text = SettingsSettings.Text.Replace("moxolib.userdefined.WebViewSource", URL);
            SettingsSettings.Text = SettingsSettings.Text.Replace("1234567890", Height);
            SettingsSettings.Text = SettingsSettings.Text.Replace("9876543210", Width);
            SettingsSettings.SaveFile(propertiesdir + @"Settings.settings", RichTextBoxStreamType.PlainText);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Visual Studio Project (*.zip)|*.zip";
            sfd.Title = "Save as Visual Studio Project";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                string Saved = sfd.FileName;
                ZipFile.CreateFromDirectory(tmpdatafolder, Saved);
                MessageBox.Show("Congratulations. Your web-app is ready! To build and customise your web-app, extract the archive and open the project in Visual Studio. For more information and a step-by-step guide, visit https://github.com/RyanWalpoleEnterprises/Moxo-QuickWeb.");
                Application.Exit();
            }
        }

        private void ApplicationWindowHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void ApplicationWindowWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void ApplicationName_TextChanged(object sender, EventArgs e)
        {
            Preview_Title.Text = ApplicationName.Text;
        }

        private void ApplicationWebViewSource_TextChanged(object sender, EventArgs e)
        {
            Preview_URL.Text = ApplicationWebViewSource.Text;
        }

        private void ApplicationWindowHeight_TextChanged(object sender, EventArgs e)
        {
            Preview_Height.Text = ApplicationWindowHeight.Text + "px";
        }

        private void ApplicationWindowWidth_TextChanged(object sender, EventArgs e)
        {
            Preview_Width.Text = ApplicationWindowWidth.Text + "px";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            string appdatadir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string userdatadir = appdatadir + @"\RWE\Moxo\QuickWeb\";
            string tmpdatafolder = userdatadir + @"tmp\";
            string propertiesdir = tmpdatafolder + @"\Moxo Web UI\Properties\";
            string appconfig = tmpdatafolder + @"\Moxo Web UI\App.config";


            DialogResult dr = MessageBox.Show("Are you sure you want to abandon your progress?", "New .NET Project | Moxo QuickWeb Studio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                if (Directory.Exists(tmpdatafolder))
                {
                    Directory.Delete(tmpdatafolder, true);
                }

                Dashboard db = new Dashboard();
                db.Show();
                this.Close();
            }
            else
            {
                //
            }
        }

        private void dotNetLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/RyanWalpoleEnterprises/Moxo-QuickWeb/wiki/QuickWeb-.NET");
        }

        private void NewDotNET_FormClosing(object sender, FormClosingEventArgs e)
        {
            CancelButton.PerformClick();
        }
    }
}
