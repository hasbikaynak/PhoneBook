using MyPhoneDirectoryProject.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyPhoneDirectoryProject.BLL
{
    public class BusinessLogicLayer
    {
        MyPhoneDirectoryProject.Core.DatabaseLogicLayer DLL;
        public BusinessLogicLayer()
        {
            DLL = new Core.DatabaseLogicLayer();
        }

        public int UserControl(string User, string Password)
        { int result = 0;
            if (!string.IsNullOrEmpty(User) && !string.IsNullOrEmpty(Password))
            {
                User user = new User();
                user.Name = User;
                user.Password = Password;
               result = DLL.ControlUser(user);
            }
            else
            {
                result = -100; // This provides me missing parameter
            }
            return result;
        }
        public int NewUser(Guid ID, string Name, string Surname, string PhoneI, string PhoneII, string PhoneIII, string Address,
            string Email, string Website, string Description)
        { int result = 0;
            if (ID != Guid.Empty && !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Surname) && !string.IsNullOrEmpty(PhoneI))
            {
                DirectorySave Registry = new DirectorySave();
                Registry.ID = ID;
                Registry.Name = Name;
                Registry.Surname = Surname;
                Registry.PhoneI = PhoneI;
                Registry.PhoneII = PhoneII;
                Registry.PhoneIII = PhoneIII;
                Registry.Address = Address;
                Registry.Email = Email;
                Registry.Website = Website;
                Registry.Description = Description;
               result = DLL.NewUser(Registry);


            }
            else
            {
                result = -100; // It will provide me missing parameter error
            }
            return result;
        }
        public int DeleteRegistry(Guid ID)
        {
            return DLL.DeleteRegistry(ID); 
        }

        public int GiveXML()
        { int result = 0;
            try
            {
                List<DirectorySave> saves = DLL.BringSaves();
                XDocument doc = new XDocument(new XDeclaration("1.0.0.1", "UTF-8", "Yes"), new XElement("DirectorySave", saves.Select(I => new XElement("Registry", new XElement("ID", I.ID), new XElement
                        ("Name", I.Name), new XElement("Surname", I.Surname), new XElement("PhoneI", I.PhoneI), new XElement("PhoneII", I.PhoneII), new XElement("PhoneIII", I.PhoneIII), new XElement
                        ("Email", I.Email), new XElement("Address", I.Address), new XElement("Website", I.Website), new XElement("Description", I.Description)))));
                doc.Save(@"c:\MyPhoneDirectoryProjectDB\GiveXML.xml");
                result = 1;
            }
            catch (Exception ex)
            {

                result = 0;
            }
            return result;

        }
        public int GiveCSV()
        { int result = 0;
            try
            {
                List<DirectorySave> saves = DLL.BringSaves();
                StreamWriter SW = new StreamWriter(@"c:\MyPhoneDirectoryProjectDB\GiveCSV.csv");
                CsvHelper.CsvWriter write = new CsvHelper.CsvWriter(SW);    
                write.WriteHeader(typeof(DirectorySave));
                foreach (var item in saves)
                {
                    write.WriteRecord(item);

                }
                SW.Close();
                result = 1;
            }
            catch (Exception ex)
            {

                result = 0;
                
            }
            return result;
        }
        public int UpdateRegistry(Guid ID, string Name, string Surname, string PhoneI, string PhoneII, string PhoneIII, string Address,
            string Email, string Website, string Description)
        {
            int result = 0;
            if (ID != Guid.Empty && !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Surname) && !string.IsNullOrEmpty(PhoneI))
            {
                DirectorySave Registry = new DirectorySave();
                Registry.ID = ID;
                Registry.Name = Name;
                Registry.Surname = Surname;
                Registry.PhoneI = PhoneI;
                Registry.PhoneII = PhoneII;
                Registry.PhoneIII = PhoneIII;
                Registry.Address = Address;
                Registry.Email = Email;
                Registry.Website = Website;
                Registry.Description = Description;
               result= DLL.NewRegistry(Registry); 


            }
            else
            {
                result = -100; // It will provide me missing parameter error
            }
            return result;

        }


        public List<DirectorySave> BringDirectorySaves()
        {
            return DLL.BringSaves();
        }
    }
}
