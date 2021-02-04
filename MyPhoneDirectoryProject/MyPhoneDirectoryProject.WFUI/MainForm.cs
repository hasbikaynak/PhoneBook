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

        private void lst_list_DoubleClick(object sender, EventArgs e)
        {
            ListBox L = (ListBox)sender;
            DirectorySave chosenvalue  = (DirectorySave)L.SelectedItem;
            txt_name.Text = chosenvalue.Name;
            txt_surname.Text = chosenvalue.Surname;
             txt_phonei.Text = chosenvalue.PhoneI;
            txt_phoneii.Text = chosenvalue.PhoneII;
           txt_phoneiii.Text = chosenvalue.PhoneIII;
              txt_email.Text = chosenvalue.Email;
            txt_website.Text = chosenvalue.Website;
            txt_address.Text = chosenvalue.Address;
        txt_description.Text = chosenvalue.Description;
            grpbox_newdirectoryregistry.Text = "Update a Directory ";

                txt_name.BackColor = Color.Yellow;
                txt_surname.BackColor = Color.Yellow;
                txt_phonei.BackColor = Color.Yellow;
                txt_phoneii.BackColor = Color.Yellow;
                txt_phoneiii.BackColor = Color.Yellow;
                txt_email.BackColor = Color.Yellow;
                txt_website.BackColor = Color.Yellow;
                txt_address.BackColor = Color.Yellow;
                txt_description.BackColor = Color.Yellow;
            
            
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (lst_list.SelectedItem != null)
            {
                DirectorySave K = (DirectorySave)lst_list.SelectedItem;
                int result = BLL.UpdateRegistry(K.ID, txt_name.Text, txt_surname.Text, txt_phonei.Text, txt_phoneii.Text, txt_phoneiii.Text, txt_address.Text, txt_email.Text, txt_website.Text, txt_description.Text);
                if (result > 0)
                {
                    MessageBox.Show("Your values uptaded successfully");
                    Fill();
                }
                else if (result == -100)
                {
                    MessageBox.Show("Missing Parameter Eror");
                }
                else
                {
                    MessageBox.Show("The problem has ben occurred");
                }

            }
        }
    }
    
}

