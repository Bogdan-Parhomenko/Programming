using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
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

        public Contact? ChangedContact { get; set; }

        public ObservableCollection<Contact>? Contacts { get; set; }

        /// <summary>
        /// Команда сохранения контакта.
        /// </summary>
        private RelayCommand? _addCommand;

        /// <summary>
        /// Возвращает способ сохранения контакта.
        /// </summary>
        public RelayCommand? AddCommand
        {
            get
            {
                return _addCommand ??=
                  (_addCommand = new RelayCommand(obj =>
                  {
                      Contact? contact = new ();
                      SelectedContact = contact;
                      ChangedContact = null;
                      //OnPropertyChanged(nameof(Visibility));
                  }));
            }
        }

        private RelayCommand? _applyCommand;

        
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
                  }));
            }
        }

        private RelayCommand? _editCommand;


        public RelayCommand? EditCommand
        {
            get
            {
                return _editCommand ??=
                  (_editCommand = new RelayCommand(obj =>
                  {
                      ChangedContact = SelectedContact;
                      SelectedContact = (Contact)SelectedContact.Clone();
                  },
                  (obj) => SelectedContact != null));
            }
        }

        /// <summary>
        /// Команда загрузки контакта.
        /// </summary>
        private RelayCommand? _removeCommand;

        /// <summary>
        /// Возвращает способ загрузки контакта.
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
                    },
                    (obj) => Contacts?.Count > 0));
            }
        }


        public bool IsReadOnly
        {
            get
            {
                if (Visibility == false)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        public bool IsEnable
        {
            get
            {
                return true;
            }
        }


        public bool Visibility
        {
            get
            {
                if (SelectedContact == null)
                {
                    return false;
                }
                else if (Contacts.Contains(SelectedContact))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }


        public Contact? SelectedContact
        {
            get => _selectedContact;
            set
            {
                _selectedContact = value;
                OnPropertyChanged(nameof(SelectedContact));
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>();
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
