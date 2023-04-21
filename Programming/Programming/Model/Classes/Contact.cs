using System;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возвращает и задает имя контакта. Должно состоять только из букв английского алфавита.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                AssertStringContainsOnlyLetters(value);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает фамилию контакта. Должна состоять только из букв английского алфавита.
        /// </summary>
        public string Surname
        {
            get => _surname;
            set
            {
                AssertStringContainsOnlyLetters(value);
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает телефонный номер контакта.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Проверяет, что строка состоит только из букв английского алфавита.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="propertyName">Имя свойства, вызвавшего данный метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если строка состоит не только из букв английского алфавита.</exception>
        private static void AssertStringContainsOnlyLetters(string value, [CallerMemberName] string propertyName = "")
        {
            if (!Regex.IsMatch(value, "^[a-zA-Z]+$"))
            {
                throw new ArgumentException($"Поле {propertyName} должно содержать только буквы английского алфавита");
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/> без его инициализации.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя контакта. Должно состоять только из букв английского алфавита.</param>
        /// <param name="surname">Фамилия контакта. Должна состоять только из букв английского алфавита.</param>
        /// <param name="phoneNumber">Телефонный ноиер контакта.</param>
        public Contact(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }
    }
}