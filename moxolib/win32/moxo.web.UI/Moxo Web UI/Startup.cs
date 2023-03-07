using Microsoft.Web.WebView2.Core;
using Moxo_Web_UI.Properties;
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

namespace Moxo_Web_UI
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();

            //Set the user data folder for WebView
            string userDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\RWE\Moxo\UserData\WV\";

            if (!Directory.Exists(userDataFolder))
            {
                Directory.CreateDirectory(userDataFolder);
            }

            //Create the user data folder if it does not already exist
            if (!Directory.Exists(userDataFolder))
            {
                Directory.CreateDirectory(userDataFolder);
            }

            //Set the current window settings
            this.Height = Properties.Settings.Default.MainWindowHeight;
            this.Width = Properties.Settings.Default.MainWindowWidth;
            this.Text = Properties.Settings.Default.ApplicationName;
        }

        private void PreInitializeBrowserAsync()
        {
            //Check WV
            if (UI_WebView == null)
            {
                //
            }

            InitializeBrowser();
        }

        private async Task InitializeBrowser()
        {
            var env = await CoreWebView2Environment.CreateAsync(null, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\RWE\Moxo\UserData\WV\");
            await UI_WebView.EnsureCoreWebView2Async(env);

            //Set the URL for the WebView
            UI_WebView.Source = new Uri(Settings.Default.WebViewSource);
        }

        private void WebView_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            //Disables the status bar that appears at the bottom of the WebView Controller.
            //The status bar displays information, such as 'Loading https://example.com'
            UI_WebView.CoreWebView2.Settings.IsStatusBarEnabled = true;

            //Set the URL for the WebView
            UI_WebView.Source = new Uri(Settings.Default.WebViewSource);

        }

        private void UI_Button_Back_Click(object sender, EventArgs e)
        {
            //If the WebView is capable of going Back, Execute GoBack();
            if (UI_WebView.CanGoBack == true)
            {
                UI_WebView.GoBack();
            }
        }

        private void UI_Button_Forward_Click(object sender, EventArgs e)
        {
            //If the WebView is capable of going Forward, Execute GoForward();
            if (UI_WebView.CanGoForward == true)
            {
                UI_WebView.GoForward();
            }
        }

        private void UI_Button_Refresh_Click(object sender, EventArgs e)
        {
            //Refresh the website in the WebView
            UI_WebView.CoreWebView2.Reload();
        }

        private void UI_Button_About_Click(object sender, EventArgs e)
        {
            UIWindowAbout UI_Window_About = new UIWindowAbout();
            UI_Window_About.ShowDialog();
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            PreInitializeBrowserAsync();
        }
    }
}
