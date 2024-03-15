using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace View.Model
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    public class Contact : INotifyPropertyChanged, ICloneable
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string? _name;

        /// <summary>
        /// Телефон контакта.
        /// </summary>
        private string? _phone;

        /// <summary>
        /// Почта контакта.
        /// </summary>
        private string? _email;

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string? Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Возвращает и задает телефон контакта.
        /// </summary>
        public string? Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        /// <summary>
        /// Возвращает и задает почту контакта.
        /// </summary>
        public string? Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// Инициализирует поля объекта.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="phone">Телефон контакта.</param>
        /// <param name="email">Почта контакта.</param>
        public Contact(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Оповещает систему об изменении свойств.
        /// </summary>
        /// <param name="prop">Свойство, которое изменилось.</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public object Clone()
        {
            return new Contact(Name, Phone, Email);
        }
    }
}
