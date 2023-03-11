using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    internal class Contact
    {
        private string _name;
        private string _surName;
        private string _phoneNumber;

        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhoneNumber { get; set; }

        public Contact()
        {

        }

        public Contact(string name, string surName, string phoneNumber)
        {
            Name = name;
            SurName = surName;
            PhoneNumber = phoneNumber;
        }
    }
}