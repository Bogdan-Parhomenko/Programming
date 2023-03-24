using System;
using System.Text.RegularExpressions;
using System.Diagnostics;

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
            var stackTrace = new StackTrace();
            var stackFrame = stackTrace.GetFrame(1);

            if (Regex.IsMatch(value, "^[a-zA-Z]+$"))
            {
            }
            else
            {
                throw new ArgumentException($"Поле {stackFrame.GetMethod().Name}" +
                                            $" класса {stackFrame.GetMethod().DeclaringType.Name}" +
                                            $" должно содержать только буквы английского алфавита");
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