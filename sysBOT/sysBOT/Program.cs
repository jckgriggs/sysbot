using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysBOT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings.Get("username")) && !string.IsNullOrEmpty(ConfigurationManager.AppSettings.Get("oauth")) && !string.IsNullOrEmpty(ConfigurationManager.AppSettings.Get("channel")) && !string.IsNullOrEmpty(ConfigurationManager.AppSettings.Get("token")))
            {
                Application.Run(new Form1(ConfigurationManager.AppSettings.Get("username"), ConfigurationManager.AppSettings.Get("oauth"), ConfigurationManager.AppSettings.Get("channel"), ConfigurationManager.AppSettings.Get("token")));
            }
            else
            {
                Application.Run(new Login());
            }
        }
    }
}
