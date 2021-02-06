using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhoneDirectoryProject.WFUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool LK = LicenseControl();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (LK)
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new LicenseScreen());
            }
            
        }
        static bool LicenseControl()
        { RegistryKey RK = Registry.CurrentUser.OpenSubKey("PhoneBook");
            if (RK != null)
            {
                string HDDSN = RK.GetValue("HardDiscSerialNumber").ToString();
                string MACADD = RK.GetValue("MACaddress").ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
