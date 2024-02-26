using System.ComponentModel;
using System.Runtime.CompilerServices;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel главного окна.
    /// </summary>
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Изменяемый контакт.
        /// </summary>
        private Contact? _contact;

        /// <summary>
        /// Команда сохранения контакта.
        /// </summary>
        private RelayCommand? _saveCommand;

        /// <summary>
        /// Возвращает способ сохранения контакта.
        /// </summary>
        public RelayCommand? SaveCommand
        {
            get
            {
                return _saveCommand ??=
                  (_saveCommand = new RelayCommand(obj =>
                  {
                      ContactSerializer.SaveContact(_contact);
                  }));
            }
        }

        /// <summary>
        /// Команда загрузки контакта.
        /// </summary>
        private RelayCommand? _loadCommand;

        /// <summary>
        /// Возвразает способ загрузки контакта.
        /// </summary>
        public RelayCommand? LoadCommand
        {
            get
            {
                return _loadCommand ??=
                    (_loadCommand = new RelayCommand(obj =>
                    {
                        Contact? contact = ContactSerializer.LoadContact();
                        Name = contact?.Name;
                        Phone = contact?.Phone;
                        Email = contact?.Email;
                    }));
            }
        }

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string? Name
        {
            get => _contact?.Name;
            set
            {
                if (_contact == null)
                {
                    return;
                }
                _contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Возвращает и задает телефон контакта.
        /// </summary>
        public string? Phone
        {
            get => _contact?.Phone;
            set
            {
                if (_contact == null)
                {
                    return;
                }
                _contact.Phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        /// <summary>
        /// Возвращает и задает почту контакта.
        /// </summary>
        public string? Email
        {
            get => _contact?.Email;
            set
            {
                if (_contact == null)
                {
                    return;
                }
                _contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            _contact = new Contact { Name = "Bob", Phone = "89", Email = "@" };
        }

        /// <summary>
        /// <inheritdoc/>.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Событие, оповещающее систему об изменении свойств.
        /// </summary>
        /// <param name="prop">Свойство, которое изменилось.</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
