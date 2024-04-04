using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace View.Model
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    public class Contact : INotifyPropertyChanged, ICloneable, INotifyDataErrorInfo
    {
        private readonly Dictionary<string, List<string>> _propertyErrors = new();
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
                CleanErrors(nameof(Name));
                if (value.Length > 100)
                {
                    AddError(nameof(Name), "Свойство Name должно быть не длиннее 100 символов.");
                }
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
                CleanErrors(nameof(Phone));
                if (value.Length > 100 || !Regex.IsMatch(value,
                    "^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$"))
                {
                    AddError(nameof(Phone),
                        "Свойство Phone должно быть не длиннее 100 символов\nи может содержать только цифры или символы +-(). Пример: +7 (999) 111-22-33.");
                }
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
                CleanErrors(nameof(Email));
                if (value.Length > 100 || !Regex.IsMatch(value,
                    "^\\S+@\\S+\\.\\S+$"))
                {
                    AddError(nameof(Email),
                        "Свойство Email должно быть не длиннее 100 символов и должно содержать символ @.");
                }

                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public bool HasErrors => _propertyErrors.Any();

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
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

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

        public IEnumerable GetErrors(string? propertyName)
        {
            return _propertyErrors.GetValueOrDefault(propertyName, null);
        }

        private void AddError(string propertyName, string errorMessage)
        {
            if(!_propertyErrors.ContainsKey(propertyName))
            {
                _propertyErrors.Add(propertyName, new List<string>());
            }

            _propertyErrors[propertyName].Add(errorMessage);
            OnErrorsChanged(propertyName);
        }

        private void CleanErrors(string propertyName)
        {
            if (_propertyErrors.Remove(propertyName))
            {
                OnErrorsChanged(propertyName);
            }
        }

        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }
    }
}
