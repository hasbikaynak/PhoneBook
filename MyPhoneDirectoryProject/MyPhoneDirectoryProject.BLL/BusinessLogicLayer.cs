using MyPhoneDirectoryProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
