using System;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

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

        private static void AssertStringContainsOnlyLetters(string value, [CallerMemberName] string propertyName = "")
        {
            if (!Regex.IsMatch(value, "^[a-zA-Z]+$"))
            {
                throw new ArgumentException($"Поле {propertyName} должно содержать только буквы английского алфавита");
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