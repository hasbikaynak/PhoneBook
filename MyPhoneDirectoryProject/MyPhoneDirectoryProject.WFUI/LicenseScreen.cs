using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhoneDirectoryProject.WFUI
{
    public partial class LicenseScreen : Form
    {
        public LicenseScreen()
        {
            InitializeComponent();
        }

       

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (txt_licensenumber.Text == "9245fe4a-d402-451c-b9ed-9c1a04247482")
            {
                string MACaddress = string.Empty;
                string HardDiscSerialNumber = string.Empty;
                string driver = "C";
                ManagementObject Disc = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + driver + ":\"");
                Disc.Get();
               HardDiscSerialNumber = Disc["VolumeSerialNumber"].ToString();
                ManagementClass MACADD = new ManagementClass("Win32_NetworkAdapterConfiguration");
               ManagementObjectCollection NAL = MACADD.GetInstances();
                foreach ( ManagementObject item in NAL)
                {
                    if ((bool)item["IPEnabled"] )
                    {
                        MACaddress = item["MacAddress"].ToString();
                    }
                    
                }
                if (!string.IsNullOrEmpty("HardDiscSerialNumber") && !string.IsNullOrEmpty("MacAddress"))
                {
                    RegistryKey Key = Registry.CurrentUser.CreateSubKey("PhoneBook", true);
                    Key.SetValue("HardDiscSerialNumber",HardDiscSerialNumber);
                    Key.SetValue("MACaddress", MACaddress);
                    MessageBox.Show("Your licensing process has been done successfully. Please restart the program", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            else
            {
                MessageBox.Show("The licence number key is wrong or damaged", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
