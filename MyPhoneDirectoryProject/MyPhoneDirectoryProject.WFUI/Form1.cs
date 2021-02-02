using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhoneDirectoryProject.WFUI
{
    public partial class Form1 : Form
    {
        MyPhoneDirectoryProject.BLL.BusinessLogicLayer BLL;
        public Form1()
        {
            InitializeComponent();
            BLL = new BLL.BusinessLogicLayer();

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            int result = BLL.UserControl(txt_username.Text, txt_password.Text);
            if (result > 0)
            {
                MainForm form = new MainForm();
                form.Show();
            }
            else if (result == -100)
            {
                MessageBox.Show("Please fill in all required fields");
            }
            else
            {
                MessageBox.Show("Wrong User");
            }
                        
                 
        }
    }
}
