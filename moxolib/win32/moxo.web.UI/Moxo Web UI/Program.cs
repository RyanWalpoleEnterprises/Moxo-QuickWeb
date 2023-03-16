using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moxo_Web_UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                var version = CoreWebView2Environment.GetAvailableBrowserVersionString();
                if(version != null)
                {
                    Application.Run(new Startup());
                }
                // Do something with `version` if needed.
            }
            catch (WebView2RuntimeNotFoundException exception)
            {
                // Handle the runtime not being installed.
                // `exception.Message` is very nicely specific: It (currently at least) says "Couldn't find a compatible Webview2 Runtime installation to host WebViews."
                //Microsoft Edge WebView2 Runtime Not Installed
                MessageBox.Show("WebView2 is not installed on this system. For more information, visit https://github.com/RyanWalpoleEnterprises/Moxo-QuickWeb");
            }
        }
    }
}
