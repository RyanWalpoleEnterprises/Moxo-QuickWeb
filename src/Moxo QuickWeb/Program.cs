using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moxo_QuickWeb
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Properties.Settings.Default.LaunchArg = null;
            Properties.Settings.Default.Save();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhkVFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jSnxSdEdgWX1YdHZdRg==;Mgo+DSMBPh8sVXJ0S0J+XE9AflRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31TdUdiW31dcHZTQmRdUQ==;ORg4AjUWIQA/Gnt2VVhkQlFacldJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkZhWH1cc3RXQGRZWUQ=;MTM5NzY5NEAzMjMwMmUzNDJlMzBqdTVnODBnc3plKzZ5OGJLRkpYRFZaRFUrZkZyN1kwWklDSEVhaHFXU0trPQ==;MTM5NzY5NUAzMjMwMmUzNDJlMzBqTGJqeTRqQmdNWGNtU1NlUGRuS0d4ZVRhbVYyV0tPckRwQVZYbmN5ZHFZPQ==;NRAiBiAaIQQuGjN/V0Z+WE9EaFtKVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUVgW35ccndVRGZZUkJ2;MTM5NzY5N0AzMjMwMmUzNDJlMzBNSXMwRFZwZmpkbzNGclR6VmdyZHhOMTg1RkZ4c3VKVVBCWENDRUV3dnRZPQ==;MTM5NzY5OEAzMjMwMmUzNDJlMzBHQnltTDNJcm1PWkdmdWkrazdMdFlrNDVoWUFEeHlpWEo2T2R0U0d5SExBPQ==;Mgo+DSMBMAY9C3t2VVhkQlFacldJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkZhWH1cc3RXQGZcVkQ=;MTM5NzcwMEAzMjMwMmUzNDJlMzBHWEFXU3FBeW14ZU56OXkyVjRQR0pYdHB1WWR0ZGNaN0g5MjNtbFhoWHV3PQ==;MTM5NzcwMUAzMjMwMmUzNDJlMzBMUS9JS3B5SUFaak1samllQmYvSHlxK3hreXh4Smw0czk5Tk40eFVKbWcwPQ==;MTM5NzcwMkAzMjMwMmUzNDJlMzBNSXMwRFZwZmpkbzNGclR6VmdyZHhOMTg1RkZ4c3VKVVBCWENDRUV3dnRZPQ==");

            string[] arguments = args;
            if (args.Length >0)
            {
                //MessageBox.Show("Arguments:" + Environment.NewLine + arguments);
                string filePath = null;
                foreach(string arg in args)
                {
                    if (File.Exists(arg))
                    {
                        filePath = arg;
                        Properties.Settings.Default.LaunchArg = args[0];
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        //do nothing
                    }
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Splash());
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Splash());
            }
        }
    }
}
