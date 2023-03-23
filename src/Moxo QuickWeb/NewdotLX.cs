using Moxo_QuickWeb.Properties;
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

namespace Moxo_QuickWeb
{
    public partial class NewdotLX : Form
    {
        public NewdotLX()
        {
            string appdatadir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string userdatadir = appdatadir + @"\RWE\Moxo\QuickWeb\";
            string tmpdatafolder = userdatadir + @"tmp\";

            if (Directory.Exists(tmpdatafolder))
            {
                Directory.Delete(tmpdatafolder, true);
            }

            InitializeComponent();

            string InstallLocation = AppDomain.CurrentDomain.BaseDirectory.ToString();
            string ZipLocation = InstallLocation + @"moxolxproj.zip";

            try
            {
                ZipFile.ExtractToDirectory(ZipLocation, tmpdatafolder);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        [DllImport("urlmon.dll", CharSet = CharSet.Auto)]
        private static extern uint FindMimeFromData(
        uint pBC,
        [MarshalAs(UnmanagedType.LPStr)] string pwzUrl,
        [MarshalAs(UnmanagedType.LPArray)] byte[] pBuffer,
        uint cbSize,
        [MarshalAs(UnmanagedType.LPStr)] string pwzMimeProposed,
        uint dwMimeFlags,
        out uint ppwzMimeOut,
        uint dwReserved);

        private void ApplicationName_Leave(object sender, EventArgs e)
        {
            CodeFile.Text = CodeFile.Text.Replace("     Settings.AppName = \"\";", "     Settings.AppName = \"" + ApplicationName.Text + "\";");
        }

        private void ApplicationVersion_Leave(object sender, EventArgs e)
        {
            CodeFile.Text = CodeFile.Text.Replace("     Settings.AppVersion = \"\";", "     Settings.AppVersion = \"" + ApplicationVersion.Text + "\";");
        }

        private void ApplicationDeveloper_Leave(object sender, EventArgs e)
        {
            CodeFile.Text = CodeFile.Text.Replace("     Settings.AppDeveloper = \"\";", "     Settings.AppDeveloper = \"" + ApplicationDeveloper.Text + "\";");
        }

        private void ApplicationPublisher_Leave(object sender, EventArgs e)
        {
            CodeFile.Text = CodeFile.Text.Replace("     Settings.AppPublisher = \"\";", "     Settings.AppPublisher = \"" + ApplicationPublisher.Text + "\";");
        }

        private void ApplicationWebViewSource_Leave(object sender, EventArgs e)
        {
            CodeFile.Text = CodeFile.Text.Replace("     Settings.WebViewURL = \"\";", "     Settings.WebViewURL = \"" + ApplicationWebViewSource.Text + "\";");
        }

        private void ApplicationWindowWidth_Leave(object sender, EventArgs e)
        {
            CodeFile.Text = CodeFile.Text.Replace("     Settings.WindowWidth = ", "     Settings.WindowWidth = " + ApplicationWindowWidth.Text);
        }

        private void ApplicationWindowHeight_Leave(object sender, EventArgs e)
        {
            CodeFile.Text = CodeFile.Text.Replace("     Settings.WindowHeight = ", "     Settings.WindowHeight = " + ApplicationWindowHeight.Text);
        }

        private void IncludeBack_CheckStateChanged(object sender, EventArgs e)
        {
            if(IncludeBack.Checked == true) { CodeFile.Text = CodeFile.Text.Replace("     Settings.BackEnabled == false;", "     Settings.BackEnabled == true;"); Preview_Back.Visible = true; }
            else { CodeFile.Text = CodeFile.Text.Replace("     Settings.BackEnabled == true;", "     Settings.BackEnabled == false;"); Preview_Back.Visible = false; }
        }

        private void IncludeForward_CheckedChanged(object sender, EventArgs e)
        {
            if (IncludeForward.Checked == true) { CodeFile.Text = CodeFile.Text.Replace("     Settings.ForwardEnabled == false;", "     Settings.ForwardEnabled == true;"); Preview_Forward.Visible = true; }
            else { CodeFile.Text = CodeFile.Text.Replace("     Settings.ForwardEnabled == true;", "     Settings.ForwardEnabled == false;"); Preview_Forward.Visible = false; }
        }

        private void IncludeRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (IncludeRefresh.Checked == true) { CodeFile.Text = CodeFile.Text.Replace("     Settings.RefreshEnabled == false;", "     Settings.RefreshEnabled == true;"); Preview_Refresh.Visible = true; }
            else { CodeFile.Text = CodeFile.Text.Replace("     Settings.RefreshEnabled == true;", "     Settings.RefreshEnabled == false;"); Preview_Refresh.Visible = false; }
        }

        private void ApplicationName_Enter(object sender, EventArgs e)
        {
            CodeFile.Text = CodeFile.Text.Replace("     Settings.AppName = \"" + ApplicationName.Text + "\";", "     Settings.AppName = \"\";");
        }

        private void ApplicationVersion_Enter(object sender, EventArgs e)
        {
            CodeFile.Text = CodeFile.Text.Replace("     Settings.AppVersion = \"" + ApplicationVersion.Text + "\";", "     Settings.AppVersion = \"\";");
        }

        private void ApplicationDeveloper_Enter(object sender, EventArgs e)
        {
            CodeFile.Text = CodeFile.Text.Replace("     Settings.AppDeveloper = \"" + ApplicationDeveloper.Text + "\";", "     Settings.AppDeveloper = \"\";");
        }

        private void ApplicationPublisher_Enter(object sender, EventArgs e)
        {
            CodeFile.Text = CodeFile.Text.Replace("     Settings.AppPublisher = \"" + ApplicationPublisher.Text + "\";", "     Settings.AppPublisher = \"\";");
        }

        private void ApplicationWebViewSource_Enter(object sender, EventArgs e)
        {
            CodeFile.Text = CodeFile.Text.Replace("     Settings.WebViewURL = \"" + ApplicationWebViewSource.Text + "\";", "     Settings.WebViewURL = \"\";");
        }

        private void ApplicationWindowWidth_Enter(object sender, EventArgs e)
        {
            CodeFile.Text = CodeFile.Text.Replace("     Settings.WindowWidth = " + ApplicationWindowWidth.Text + ";", "     Settings.WindowWidth = ;");
        }

        private void ApplicationWindowHeight_Enter(object sender, EventArgs e)
        {
            CodeFile.Text = CodeFile.Text.Replace("     Settings.WindowHeight = " + ApplicationWindowHeight.Text + ";", "     Settings.WindowHeight = ;");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CancelRoute = "TRUE";
            this.Close();
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

        private void NewdotLX_FormClosing(object sender, FormClosingEventArgs e)
        {
            string appdatadir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string userdatadir = appdatadir + @"\RWE\Moxo\QuickWeb\";
            string tmpdatafolder = userdatadir + @"tmp\";
            string propertiesdir = tmpdatafolder + @"\Moxo Web UI\Properties\";
            string appconfig = tmpdatafolder + @"\Moxo Web UI\App.config";

            if (Properties.Settings.Default.CancelRoute == "TRUE")
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to abandon your progress?", "New dotLX Project | Moxo QuickWeb Studio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Properties.Settings.Default.CancelRoute = null;
                    Dashboard db = new Dashboard();
                    db.Show();
                }
                else
                {
                    //
                }
            }
            else
            {
                //
            }

            Properties.Settings.Default.CancelRoute = null;
        }

        private void IconBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Icon File|*.ico";
            ofd.Title = "Select an Icon for your Web-App";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                iconFileName.Text = ofd.SafeFileName;
                Properties.Settings.Default.dotLX_tmpICO = ofd.FileName;
                Properties.Settings.Default.Save();

                // Get the file path
                string filePath = ofd.FileName;

                // Read the first 256 bytes of the file into a buffer
                byte[] buffer = new byte[256];
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    fs.Read(buffer, 0, 256);
                }

                // Determine the mime type using the FindMimeFromData function
                uint mimeType;
                FindMimeFromData(0, null, buffer, 256, null, 0, out mimeType, 0);

                // Convert the mime type from a uint to a string
                string mimeTypeString = Marshal.PtrToStringUni((IntPtr)mimeType);

                // Parse the mime type
                //MessageBox.Show(mimeTypeString);
                if (String.IsNullOrWhiteSpace(mimeTypeString))
                {
                    //Cannot determine, assume safe.
                }
                else if (mimeTypeString.Contains("icon"))
                {
                    //Valid icon file
                }
                else if(!mimeTypeString.Contains("icon"))
                {
                    //Does not contain the correct mime type
                    MessageBox.Show("The ico file you selected reported a MIME file type of " + mimeTypeString + "." + Environment.NewLine + Environment.NewLine + "This may not be a valid icon file and may cause issues in your application.", "Warning | Moxo QuickWeb Studio [dotLX]", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            ContinueButton.Enabled = false;
            CancelButton.Enabled = false;

            string InstallLocation = AppDomain.CurrentDomain.BaseDirectory.ToString();
            string ZipLocation = InstallLocation + @"moxolxproj.zip";
            string appdatadir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string userdatadir = appdatadir + @"\RWE\Moxo\QuickWeb\";
            string tmpdatafolder = userdatadir + @"tmp\";

            CodeFile.LoadFile(tmpdatafolder + @"program.clx", RichTextBoxStreamType.PlainText);
            CodeFile.Text = CodeFile.Text.Replace("moxlibreplaceAPPNAME", ApplicationName.Text);
            CodeFile.Text = CodeFile.Text.Replace("moxlibreplaceVERSION", ApplicationVersion.Text);
            CodeFile.Text = CodeFile.Text.Replace("moxlibreplaceDEVELOPER", ApplicationDeveloper.Text);
            CodeFile.Text = CodeFile.Text.Replace("moxlibreplacePUBLISHER", ApplicationPublisher.Text);
            
            //If webview URL is null or empty, give it the default value
            if (!string.IsNullOrWhiteSpace(ApplicationWebViewSource.Text)) 
            { 
                CodeFile.Text = CodeFile.Text.Replace("moxlibreplaceWEBVIEWSOURCE", ApplicationWebViewSource.Text); 
            } 
            else 
            { 
                CodeFile.Text = CodeFile.Text.Replace("moxlibreplaceWEBVIEWSOURCE", "https://www.ryanwalpole.com/developer/moxo/qws/example"); 
            }

            //If webview URL is still https with no URL, give it the default value
            if (ApplicationWebViewSource.Text == "https://") 
            { 
                CodeFile.Text = CodeFile.Text.Replace("moxlibreplaceWEBVIEWSOURCE", "https://www.ryanwalpole.com/developer/moxo/qws/example"); 
            } 
            else 
            {
            }

            //Set the window width values
            if (!string.IsNullOrWhiteSpace(ApplicationWindowWidth.Text))
            { 
                CodeFile.Text = CodeFile.Text.Replace("moxlibreplaceWIDTH", ApplicationWindowWidth.Text); 
            }
            //Unless they're empty.
            else if (string.IsNullOrWhiteSpace(ApplicationWindowWidth.Text))
            { 
                CodeFile.Text = CodeFile.Text.Replace("moxlibreplaceWIDTH", "800"); 
            }
            
            //Set the window height values
            if (!string.IsNullOrWhiteSpace(ApplicationWindowHeight.Text))
            { 
                CodeFile.Text = CodeFile.Text.Replace("moxlibreplaceHEIGHT", ApplicationWindowHeight.Text); 
            } 
            //unless they're empty
            else if (string.IsNullOrWhiteSpace(ApplicationWindowHeight.Text))
            { 
                CodeFile.Text = CodeFile.Text.Replace("moxlibreplaceHEIGHT", "800"); 
            }
            
            if (IncludeBack.Checked == true) { CodeFile.Text = CodeFile.Text.Replace("moxlibreplaceBACK", "true"); } else { CodeFile.Text = CodeFile.Text.Replace("moxlibreplaceBACK", "false"); }
            if (IncludeForward.Checked == true) { CodeFile.Text = CodeFile.Text.Replace("moxlibreplaceFORWARD", "true"); } else { CodeFile.Text = CodeFile.Text.Replace("moxlibreplaceFORWARD", "false"); }
            if (IncludeRefresh.Checked == true) { CodeFile.Text = CodeFile.Text.Replace("moxlibreplaceREFRESH", "true"); } else { CodeFile.Text = CodeFile.Text.Replace("moxlibreplaceREFRESH", "false"); }
            CodeFile.SaveFile(tmpdatafolder + @"program.clx", RichTextBoxStreamType.PlainText);

            if (Properties.Settings.Default.dotLX_tmpICO != null)
            {
                File.Delete(tmpdatafolder + @"default.ico");
                File.Copy(Properties.Settings.Default.dotLX_tmpICO, tmpdatafolder + @"default.ico");
            }
            else
            {
                //do nothing
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Moxo Application (*.zip)|*.zip";
            sfd.Title = "Save Application";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string Saved = sfd.FileName;
                try
                {
                    ZipFile.CreateFromDirectory(tmpdatafolder, Saved);
                    DialogResult dr = MessageBox.Show("Your application has been built. We've saved it as a ZIP archive. To start using your application, simply unzip it and launch the executable.", "Application Generated | Moxo QuickWeb Studio [dotLX]", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        DummyCleanup.Start();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("MOXDLX113A: There was a problem saving your application: " + Environment.NewLine + Environment.NewLine + ex.Message);
                    CancelButton.Enabled = true;
                    ContinueButton.Enabled = true;
                }
            }
        }

        private void DummyCleanup_Tick(object sender, EventArgs e)
        {
            string appdatadir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string userdatadir = appdatadir + @"\RWE\Moxo\QuickWeb\";
            string tmpdatafolder = userdatadir + @"tmp\";
            Properties.Settings.Default.CancelRoute = "FALSE";

            DummyCleanup.Stop();
            Directory.Delete(tmpdatafolder, true);
            Application.Exit();
        }

        private void dotNetLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/RyanWalpoleEnterprises/Moxo-QuickWeb/wiki/QuickWeb-dotLX");
        }

        private void IconLearnMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/RyanWalpoleEnterprises/Moxo-QuickWeb/wiki/%5BdotLX%5D-Creating-a-New-Project-%5BCustomisation-Options%5D#custom-icon-support");
        }

        private void IconPNGConvert_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dr = MessageBox.Show("We recommend using CloudConvert to convert your PNG to ICO. Would you like to open CloudConvert in your browser?", "PNG to ICO Conversion | Moxo QuickWeb Studio [dotLX]", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) {
                Process.Start("https://cloudconvert.com/png-to-ico");
                    }
            else
            {
                //do nothing
            }
        }
    }
}
