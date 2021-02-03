
namespace MyPhoneDirectoryProject.WFUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_registry = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_website = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_phoneiii = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_phoneii = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_phonei = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.lst_list = new System.Windows.Forms.ListBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_givexml = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_takexml = new System.Windows.Forms.Button();
            this.btn_givejson = new System.Windows.Forms.Button();
            this.btn_givecsv = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_list);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(339, 683);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directory List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_registry);
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(363, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(556, 683);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New Directory Registry";
            // 
            // btn_registry
            // 
            this.btn_registry.Location = new System.Drawing.Point(19, 608);
            this.btn_registry.Margin = new System.Windows.Forms.Padding(4);
            this.btn_registry.Name = "btn_registry";
            this.btn_registry.Size = new System.Drawing.Size(521, 28);
            this.btn_registry.TabIndex = 1;
            this.btn_registry.Text = "New Registry";
            this.btn_registry.UseVisualStyleBackColor = true;
            this.btn_registry.Click += new System.EventHandler(this.btn_registry_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 23);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(536, 577);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_address);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_website);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txt_email);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_phoneiii);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_phoneii);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_phonei);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_surname);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_name);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(528, 548);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personel Informations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(123, 326);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(371, 211);
            this.txt_address.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 330);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Address";
            // 
            // txt_website
            // 
            this.txt_website.Location = new System.Drawing.Point(123, 282);
            this.txt_website.Margin = new System.Windows.Forms.Padding(4);
            this.txt_website.Name = "txt_website";
            this.txt_website.Size = new System.Drawing.Size(371, 22);
            this.txt_website.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 286);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Website";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(123, 234);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(371, 22);
            this.txt_email.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email";
            // 
            // txt_phoneiii
            // 
            this.txt_phoneiii.Location = new System.Drawing.Point(123, 193);
            this.txt_phoneiii.Margin = new System.Windows.Forms.Padding(4);
            this.txt_phoneiii.Name = "txt_phoneiii";
            this.txt_phoneiii.Size = new System.Drawing.Size(371, 22);
            this.txt_phoneiii.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone III";
            // 
            // txt_phoneii
            // 
            this.txt_phoneii.Location = new System.Drawing.Point(123, 150);
            this.txt_phoneii.Margin = new System.Windows.Forms.Padding(4);
            this.txt_phoneii.Name = "txt_phoneii";
            this.txt_phoneii.Size = new System.Drawing.Size(371, 22);
            this.txt_phoneii.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone II";
            // 
            // txt_phonei
            // 
            this.txt_phonei.Location = new System.Drawing.Point(123, 110);
            this.txt_phonei.Margin = new System.Windows.Forms.Padding(4);
            this.txt_phonei.Name = "txt_phonei";
            this.txt_phonei.Size = new System.Drawing.Size(371, 22);
            this.txt_phonei.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phone I";
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(123, 65);
            this.txt_surname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(371, 22);
            this.txt_surname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(123, 21);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(371, 22);
            this.txt_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_description);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(528, 548);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Description";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(4, 7);
            this.txt_description.Margin = new System.Windows.Forms.Padding(4);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(516, 530);
            this.txt_description.TabIndex = 0;
            // 
            // lst_list
            // 
            this.lst_list.FormattingEnabled = true;
            this.lst_list.ItemHeight = 16;
            this.lst_list.Location = new System.Drawing.Point(7, 25);
            this.lst_list.Name = "lst_list";
            this.lst_list.Size = new System.Drawing.Size(325, 644);
            this.lst_list.TabIndex = 0;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(19, 641);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(521, 28);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_registry_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_status);
            this.groupBox3.Controls.Add(this.btn_givecsv);
            this.groupBox3.Controls.Add(this.btn_givejson);
            this.groupBox3.Controls.Add(this.btn_takexml);
            this.groupBox3.Controls.Add(this.btn_givexml);
            this.groupBox3.Location = new System.Drawing.Point(16, 705);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(891, 142);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATA Give-Get";
            // 
            // btn_givexml
            // 
            this.btn_givexml.Location = new System.Drawing.Point(31, 49);
            this.btn_givexml.Name = "btn_givexml";
            this.btn_givexml.Size = new System.Drawing.Size(102, 62);
            this.btn_givexml.TabIndex = 0;
            this.btn_givexml.Text = "GIVE XML ";
            this.btn_givexml.UseVisualStyleBackColor = true;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_status.Location = new System.Drawing.Point(599, 63);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(212, 25);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "STATUS : WAITING";
            // 
            // btn_takexml
            // 
            this.btn_takexml.Location = new System.Drawing.Point(163, 49);
            this.btn_takexml.Name = "btn_takexml";
            this.btn_takexml.Size = new System.Drawing.Size(102, 62);
            this.btn_takexml.TabIndex = 0;
            this.btn_takexml.Text = "TAKE XML ";
            this.btn_takexml.UseVisualStyleBackColor = true;
            // 
            // btn_givejson
            // 
            this.btn_givejson.Location = new System.Drawing.Point(293, 49);
            this.btn_givejson.Name = "btn_givejson";
            this.btn_givejson.Size = new System.Drawing.Size(102, 62);
            this.btn_givejson.TabIndex = 0;
            this.btn_givejson.Text = "GIVE JSON";
            this.btn_givejson.UseVisualStyleBackColor = true;
            // 
            // btn_givecsv
            // 
            this.btn_givecsv.Location = new System.Drawing.Point(425, 49);
            this.btn_givecsv.Name = "btn_givecsv";
            this.btn_givecsv.Size = new System.Drawing.Size(102, 62);
            this.btn_givecsv.TabIndex = 0;
            this.btn_givecsv.Text = "GIVE CSV";
            this.btn_givecsv.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 859);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_registry;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_website;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_phoneiii;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_phoneii;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_phonei;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.ListBox lst_list;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_givecsv;
        private System.Windows.Forms.Button btn_givejson;
        private System.Windows.Forms.Button btn_takexml;
        private System.Windows.Forms.Button btn_givexml;
    }
}