using System.Collections.ObjectModel;
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
        private Contact? _selectedContact;

        /// <summary>
        /// Возвращает и задает копию изменяемого контакта.
        /// </summary>
        public Contact? ChangedContact { get; set; }

        /// <summary>
        /// Коллекция контактов.
        /// </summary>
        public ObservableCollection<Contact>? Contacts { get; set; }

        /// <summary>
        /// Команда добавления контакта.
        /// </summary>
        private RelayCommand? _addCommand;

        /// <summary>
        /// Возвращает способ добавления контакта.
        /// </summary>
        public RelayCommand? AddCommand
        {
            get
            {
                return _addCommand ??=
                  (_addCommand = new RelayCommand(obj =>
                  {
                      Contact? contact = new();
                      SelectedContact = contact;
                      ChangedContact = null;
                      RefreshProperties();
                  }));
            }
        }

        /// <summary>
        /// Команда принятия изменений.
        /// </summary>
        private RelayCommand? _applyCommand;

        /// <summary>
        /// Возвращает способ принятия изменений.
        /// </summary>
        public RelayCommand? ApplyCommand
        {
            get
            {
                return _applyCommand ??=
                  (_applyCommand = new RelayCommand(obj =>
                  {
                      if (ChangedContact != null)
                      {
                          Contacts.Insert(Contacts.IndexOf(ChangedContact), SelectedContact);
                          Contacts.Remove(ChangedContact);
                      }
                      else
                      {
                          Contacts?.Insert(0, SelectedContact);
                      }
                      RefreshProperties();
                      с
                  }));
            }
        }

        /// <summary>
        /// Команда изменения контакта.
        /// </summary>
        private RelayCommand? _editCommand;

        /// <summary>
        /// Возвращает способ изменения контакта.
        /// </summary>
        public RelayCommand? EditCommand
        {
            get
            {
                return _editCommand ??=
                  (_editCommand = new RelayCommand(obj =>
                  {
                      ChangedContact = SelectedContact;
                      SelectedContact = (Contact)SelectedContact.Clone();
                      RefreshProperties();
                  },
                  (obj) => SelectedContact != null && Contacts.Contains(SelectedContact)));
            }
        }

        /// <summary>
        /// Команда удаления контакта.
        /// </summary>
        private RelayCommand? _removeCommand;

        /// <summary>
        /// Возвращает способ удаления контакта.
        /// </summary>
        public RelayCommand? RemoveCommand
        {
            get
            {
                return _removeCommand ??=
                    (_removeCommand = new RelayCommand(obj =>
                    {
                        if (obj is Contact contact)
                        {
                            if (Contacts?.Count == 1)
                            {
                                SelectedContact = null;
                            }
                            else if (Contacts?.IndexOf(contact) + 1 == Contacts?.Count)
                            {
                                SelectedContact = Contacts?[Contacts.IndexOf(contact) - 1];
                            }
                            else
                            {
                                SelectedContact = Contacts?[Contacts.IndexOf(contact) + 1];
                            }
                            Contacts?.Remove(contact);
                        }
                        ContactSerializer.SaveContacts(Contacts);
                    },
                    (obj) => Contacts?.Count > 0 && Contacts.Contains(SelectedContact)));
            }
        }

        /// <summary>
        /// Возвращает свойство IsReadOnly графического интерфейса.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return !Visibility;
            }
        }

        /// <summary>
        /// Возвращает свойство IsEnable графического интерфейса.
        /// </summary>
        public bool IsEnable
        {
            get
            {
                return !Visibility;
            }
        }

        /// <summary>
        /// Возвращает свойство Visibility графического интерфейса.
        /// </summary>
        public bool Visibility
        {
            get
            {
                return !(SelectedContact == null || Contacts.Contains(SelectedContact));
            }
        }

        /// <summary>
        /// Обновляет свойства интерфейса.
        /// </summary>
        private void RefreshProperties()
        {
            OnPropertyChanged(nameof(Visibility));
            OnPropertyChanged(nameof(IsReadOnly));
            OnPropertyChanged(nameof(IsEnable));
        }

        /// <summary>
        /// Возвращает и задает выбранный контакт.
        /// </summary>
        public Contact? SelectedContact
        {
            get => _selectedContact;
            set
            {
                _selectedContact = value;
                OnPropertyChanged(nameof(SelectedContact));
                RefreshProperties();
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = ContactSerializer.LoadContacts();
        }

        /// <summary>
        /// <inheritdoc/>.
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
    }
}
