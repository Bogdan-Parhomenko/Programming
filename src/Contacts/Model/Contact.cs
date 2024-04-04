using CommunityToolkit.Mvvm.ComponentModel;
using Model.Services;
using System.Collections;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Хранит информацию о контакте.
    /// </summary>
    public class Contact : ObservableObject, ICloneable, INotifyDataErrorInfo
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
        /// Экземпляр сервисного класса для вывода ошибок.
        /// </summary>
        private readonly ErrorsValidator _errorsValidator = new();

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// Свойство Name должно быть не длиннее 100 символов.
        /// </summary>
        public string? Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _errorsValidator.CleanErrors(nameof(Name));
                    if (value.Length > 100)
                    {
                        _errorsValidator.AddError(nameof(Name), "Свойство Name должно быть не длиннее 100 символов.");
                    }
                }
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Возвращает и задает телефон контакта.
        /// Свойство Phone должно быть не длиннее 100 символов\nи может содержать только цифры или символы +-(). Пример: +7 (999) 111-22-33.
        /// </summary>
        public string? Phone
        {
            get => _phone;
            set
            {
                if (value != null)
                {
                    _errorsValidator.CleanErrors(nameof(Phone));
                    if (value.Length > 100 || !Regex.IsMatch(value,
                        "^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$"))
                    {
                        _errorsValidator.AddError(nameof(Phone),
                            "Свойство Phone должно быть не длиннее 100 символов\nи может содержать только цифры или символы +-().\nПример: +7 (999) 111-22-33.");
                    }
                }
                _phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        /// <summary>
        /// Возвращает и задает почту контакта.
        /// Свойство Email должно быть не длиннее 100 символов и должно содержать символ @.
        /// </summary>
        public string? Email
        {
            get => _email;
            set
            {
                if (value != null)
                {
                    _errorsValidator.CleanErrors(nameof(Email));
                    if (value.Length > 100 || !Regex.IsMatch(value,
                        "^\\S+@\\S+\\.\\S+$"))
                    {
                        _errorsValidator.AddError(nameof(Email),
                            "Свойство Email должно быть не длиннее 100 символов и должно содержать символ @.");
                    }
                }
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
        /// <returns><inheritdoc/></returns>
        public object Clone()
        {
            return new Contact(Name, Phone, Email);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool HasErrors => _errorsValidator.HasErrors;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="propertyName"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public IEnumerable GetErrors(string? propertyName)
        {
            return _errorsValidator.GetErrors(propertyName);
        }
    }
}
