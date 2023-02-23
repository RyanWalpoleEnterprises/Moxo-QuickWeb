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
                string WV = CoreWebView2Environment.GetAvailableBrowserVersionString();

                if (WV != null)
                {
                    Application.Run(new Startup());
                }
                else
                {
                    //Microsoft Edge WebView2 Runtime Not Installed
                    MessageBox.Show("WebView2 is not installed on this system. For more information, visit https://github.com/RyanWalpoleEnterprises/Moxo-QuickWeb");
                }
            }
            catch
            {
                //Microsoft Edge WebView2 Runtime Assumed Not Installed
                MessageBox.Show("WebView2 is not installed on this system. For more information, visit https://github.com/RyanWalpoleEnterprises/Moxo-QuickWeb");
            }
        }
    }
}
