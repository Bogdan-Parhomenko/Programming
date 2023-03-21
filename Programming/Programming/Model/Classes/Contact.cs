using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _name;
        private string _surname;
        private string _phoneNumber;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                AssertStringContainsOnlyLetters(value);
                _name = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                AssertStringContainsOnlyLetters(value);
                _surname = value;
            }
        }

        public string PhoneNumber { get; set; }

        private static void AssertStringContainsOnlyLetters(string value)
        {
            if (Regex.IsMatch(value, "^[a-zA-Z]+$"))
            {
            }
            else
            {
                //TODO: вместо value должно стоять свойство поля откуда вызывается этот метод
                throw new ArgumentException($"Поле {value} должно содержать только буквы английского алфавита");
            }
        }

        public Contact()
        {

        }

        public Contact(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }
    }
}