using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moxo_Web_UI
{
    public partial class UIWindowAbout : Form
    {
        public UIWindowAbout()
        {
            InitializeComponent();

            //Set the Window title
            this.Text = "About - " +  Properties.Settings.Default.ApplicationName;

            //Define Application Name, Developer, Publisher and Version
            UI_AboutData.Text = Properties.Settings.Default.ApplicationName + Environment.NewLine + Properties.Settings.Default.Developer + Environment.NewLine + Properties.Settings.Default.Publisher + Environment.NewLine + Properties.Settings.Default.Version;
        }

        private void UI_LinkButton_Moxo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Removing the Moxo Link is a violation of the Moxo QuickWeb License. Do not remove this code, or the UI elements associated with it.
            string MoxoLink = "https://github.com/RyanWalpoleEnterprises/Moxo-QuickWeb";
            Process.Start(MoxoLink);
        }

        private void UI_Button_Close_Click(object sender, EventArgs e)
        {
            //Code executed on clicking the Close Button
            this.Close();
        }
    }
}
