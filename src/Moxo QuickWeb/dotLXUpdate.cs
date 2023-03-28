using Ionic.Zip;
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
using static System.Net.WebRequestMethods;

namespace Moxo_QuickWeb
{
    public partial class dotLXUpdate : Form
    {
        public dotLXUpdate()
        {
            InitializeComponent();
        }

        private void BrowseToDirectory_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Moxo LX Application (*.exe)|*.exe";
            ofd.Title = "Save Application";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string Dir = Path.GetDirectoryName(ofd.FileName);
                AppDirectoryPath.Text = Dir;
            }
        }

        private void AppDirectoryPath_TextChanged(object sender, EventArgs e)
        {
            foreach (string file in Directory.GetFiles(AppDirectoryPath.Text))
            {
                string filename = Path.GetFileName(file);
                ListFiles.AppendText(filename + Environment.NewLine);

                if (filename.Contains("framework.mxv"))
                {
                    MoxoVer.LoadFile(file, RichTextBoxStreamType.PlainText);
                }
                if (filename.Contains("program.clx"))
                {
                    ProgramCLX.LoadFile(file, RichTextBoxStreamType.PlainText);
                }
            }
            
            if(string.IsNullOrWhiteSpace(MoxoVer.Text))
            {
                //Assume v 1.0
                MoxoVer.AppendText("1.0");
            }

            Overview.Visible = true;
        }

        private void MoxoVer_TextChanged(object sender, EventArgs e)
        {
            FrameworkVer.Text = MoxoVer.Text;

            if (MoxoVer.Text.Contains(Properties.Settings.Default.dotLXFrameworkVersion))
            {
                //Application is already using latest Moxo Framework
                Close.Enabled = true;
                ApplyUpdate.Enabled = false;
                UpdateDetails.Text = "Your dotLX Moxo Application is already up to date, with the most recent version of the dotLX Framework for Moxo.";
            }
            else if (!MoxoVer.Text.Contains(Properties.Settings.Default.dotLXFrameworkVersion))
            {
                //Application can update to the new Moxo Framework
                Close.Enabled = true;
                ApplyUpdate.Enabled = true;
                UpdateDetails.Text = "Your dotLX Moxo Application can be updated to the most recent version of the dotLX Framework, version " + Properties.Settings.Default.dotLXFrameworkVersion + ".";
            }
        }

        private void ProgramCLX_TextChanged(object sender, EventArgs e)
        {
            foreach (string line in ProgramCLX.Lines)
            {
                if (line.StartsWith("     Settings.AppName = \""))
                {
                    string name = line.Replace("     Settings.AppName = \"", null).Replace("\";",null);
                    AppName.Text = name;
                }
                if (line.StartsWith("     Settings.AppVersion = \""))
                {
                    string ver = line.Replace("     Settings.AppVersion = \"", null).Replace("\";", null);
                    AppVersion.Text = ver;
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ApplyUpdate_Click(object sender, EventArgs e)
        {
            string InstallLocation = AppDomain.CurrentDomain.BaseDirectory.ToString();
            string UpdatePath = InstallLocation + @"latestdlxframework.zip";
            string ExtractPath = AppDirectoryPath.Text;

            using(ZipFile zip = ZipFile.Read(UpdatePath))
            {
                foreach(ZipEntry entry in zip.Entries)
                {
                    entry.Extract(ExtractPath, ExtractExistingFileAction.OverwriteSilently);
                }
            }

            MessageBox.Show("Your application has been updated to the latest version of the dotLX Framework for Moxo. Your application will now benefit from any improvements that have been made to the dotLX experience, even if you generated your app in an older version.","Update Framework | Moxo QuickkWeb Studio for dotLX", MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
    }
}
