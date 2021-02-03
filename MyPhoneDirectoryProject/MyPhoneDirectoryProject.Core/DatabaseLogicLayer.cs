using MyPhoneDirectoryProject.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhoneDirectoryProject.Core
{
    public class DatabaseLogicLayer
    {
        List<DirectorySave> saves;
        public DatabaseLogicLayer()
        {
            saves = new List<DirectorySave>();
            DatabaseControl();
        }

        private void DatabaseControl()
        {
           bool FileControl = Directory.Exists(@"c:\MyPhoneDirectoryProjectDB\");
            if (!FileControl)
            {
                Directory.CreateDirectory(@"c:\MyPhoneDirectoryProjectDB\");
                User Demo = new User();
                Demo.ID = Guid.NewGuid();
                Demo.Name = "Demo";
                Demo.Password = "Demo";

                string JsonUsersText = Newtonsoft.Json.JsonConvert.SerializeObject(Demo);
                File.WriteAllText(@"c:\MyPhoneDirectoryProjectDB\User.json", JsonUsersText);

            }
             
        }

        public int NewUser(DirectorySave K)
        {
            int Result = 0;
            try
            {
                BringSaves(); // class seviyesinde olusturmus oldugum koleksiyonum icersine datami doldurdum(varsa), yoksa zaten 
                //bellekte hicbir degeri yoktu o sekilde yeni deger eklenmek uzere bekliyor.
                saves.Add(K); // koleksiyonumuza degerimizi ekledik.
                JsonDBUpdate(); // var ise uzerine yazdi yok ise yeni json olusturdu.
                Result=1;
            }
            catch (Exception ex)
            {

                Result = 0;
            } 
            return Result;
        }
        public int NewRegistry(DirectorySave K)
        {
            int result = 0;
            try
            {
                BringSaves();
                int index = saves.FindIndex(I => I.ID == K.ID);
                if (index > -1)
                {
                    saves[index].Name = K.Name;
                    saves[index].Surname = K.Surname;
                    saves[index].Email = K.Email;
                    saves[index].PhoneI = K.PhoneI;
                    saves[index].PhoneII = K.PhoneII;
                    saves[index].PhoneIII = K.PhoneIII;
                    saves[index].Address = K.Address;
                    saves[index].Website = K.Website;
                    saves[index].Description = K.Description;
                }
                JsonDBUpdate();
                result = 1;
                // go to main form and do update button and create new delete button
            }
            catch (Exception ex)
            {

                
            }
            return result;
           
            
            
        }
        public List<DirectorySave> BringSaves()
        {
            if (File.Exists(@"c:\MyPhoneDirectoryProjectDB\Directory.json"))
            {
               string JsonDBtext = File.ReadAllText(@"c:\MyPhoneDirectoryProjectDB\Directory.json");
               saves  = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DirectorySave>>(JsonDBtext);
            }
            return saves;

           
        }
        public int ControlUser(User user)
        {
            int userresult = 0;
            if (File.Exists(@"c:\MyPhoneDirectoryProjectDB\User.json"))
            {
               string JsonUserText= File.ReadAllText(@"c:\MyPhoneDirectoryProjectDB\User.json");
                List<User> users = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>
                    (JsonUserText);
               userresult = users.FindAll(I => I.Name == user.Name && I.Password == user.Password).ToList().Count();
            }
            return userresult;
            
        }
        #region Helper Methods 
        private void JsonDBUpdate()
        {
            if (saves != null && saves.Count > 0)
            {
               string JsonDB = Newtonsoft.Json.JsonConvert.SerializeObject(saves);
                File.WriteAllText(@"c:\MyPhoneDirectoryProjectDB\Directory.json", JsonDB);
            }
        }

        #endregion
    }
}
