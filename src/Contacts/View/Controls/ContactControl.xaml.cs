using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace View.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        /// <summary>
        /// Инициализация компонентов главного окна.
        /// </summary>
        public ContactControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Выводит в TextBox только символы необходимые для записи телефона.
        /// </summary>
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out _) &&
                e.Text != "-" && 
                e.Text != "(" &&
                e.Text != ")" && 
                e.Text != "+")
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Не дает вставить из буфера обмена строку, не являющуюся номером телефона.
        /// </summary>
        private void TextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            string text = (string)e.DataObject.GetData(typeof(string));
            if (!Regex.IsMatch(text,
                    "^\\+?\\d{1,4}?[-.\\s]?\\(?\\d{1,3}?\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$"))
            {
                e.CancelCommand();
            }
        }
    }
}
