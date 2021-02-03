using MyPhoneDirectoryProject.Entities;
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

namespace MyPhoneDirectoryProject.WFUI
{
    public partial class MainForm : Form
    {
        MyPhoneDirectoryProject.BLL.BusinessLogicLayer BLL;
        public MainForm()
        {
            InitializeComponent();
            BLL = new BLL.BusinessLogicLayer();
        }

        private void btn_registry_Click(object sender, EventArgs e)
        {
            int result = BLL.NewUser(Guid.NewGuid(), txt_name.Text, txt_surname.Text, txt_phonei.Text, txt_phoneii.Text, txt_phoneiii.Text, txt_address.Text, txt_email.Text, txt_website.Text,
                txt_description.Text);
            if (result > 0)
            {
                MessageBox.Show("Your data has been saved successfully");
                Fill();
            }
            else if (result == -100)
            {
                MessageBox.Show("Missing parametr error, Please make sure you fill in all required fields");
            }
            else
            {
                MessageBox.Show("Occurred problem, Please try again");
            }

        }
        private void Fill()
        {
            List<DirectorySave> MySaves = BLL.BringDirectorySaves();
            if (MySaves != null && MySaves.Count > 0)
            {
                lst_list.DataSource = MySaves;
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Fill();
        }
    }
    
}

