using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhoneDirectoryProject.Entities
{
   public class DirectorySave
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string  Surname { get; set; }
        public string PhoneI { get; set; }
        public string PhoneII { get; set; }
        public string PhoneIII { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
    
}
