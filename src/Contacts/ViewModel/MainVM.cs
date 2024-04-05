using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using Model;
using Model.Services;

namespace ViewModel
{
    /// <summary>
    /// ViewModel главного окна.
    /// </summary>
    public class MainVM : ObservableObject
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
        public RelayCommand? AddCommand => _addCommand ??=
                  new RelayCommand(() =>
                  {
                      SelectedContact = new Contact();
                      ChangedContact = null;
                      RefreshProperties();
                  });

        /// <summary>
        /// Команда принятия изменений.
        /// </summary>
        private RelayCommand? _applyCommand;

        /// <summary>
        /// Возвращает способ принятия изменений.
        /// </summary>
        public RelayCommand? ApplyCommand => _applyCommand ??=
                  new RelayCommand(() =>
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
                      ContactSerializer.SaveContacts(Contacts);
                  },
                  () => SelectedContact != null && !SelectedContact.HasErrors);

        /// <summary>
        /// Команда изменения контакта.
        /// </summary>
        private RelayCommand? _editCommand;

        /// <summary>
        /// Возвращает способ изменения контакта.
        /// </summary>
        public RelayCommand? EditCommand => _editCommand ??=
                  new RelayCommand(() =>
                  {
                      ChangedContact = SelectedContact;
                      SelectedContact = (Contact)SelectedContact.Clone();
                      RefreshProperties();
                  },
                  () => SelectedContact != null && Contacts.Contains(SelectedContact));

        /// <summary>
        /// Команда удаления контакта.
        /// </summary>
        private RelayCommand? _removeCommand;

        /// <summary>
        /// Возвращает способ удаления контакта.
        /// </summary>
        public RelayCommand? RemoveCommand => _removeCommand ??=
                    new RelayCommand(() =>
                    {
                        var removedContact = SelectedContact;
                        if (Contacts?.Count == 1)
                        {
                            SelectedContact = null;
                        }
                        else if (Contacts?.IndexOf(removedContact) + 1 == Contacts?.Count)
                        {
                            SelectedContact = Contacts?[Contacts.IndexOf(removedContact) - 1];
                        }
                        else
                        {
                            SelectedContact = Contacts?[Contacts.IndexOf(removedContact) + 1];
                        }
                        Contacts?.Remove(removedContact);
                        ContactSerializer.SaveContacts(Contacts);
                    },
                    () => Contacts?.Count > 0 && Contacts.Contains(SelectedContact));

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
    }
}
