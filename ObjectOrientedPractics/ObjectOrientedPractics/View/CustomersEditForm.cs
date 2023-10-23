using System;
using System.Drawing;
using ObjectOrientedPractics.Model;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View
{
    /// <summary>
    /// Содержит логику формы изменения покупателей.
    /// </summary>
    public partial class CustomersEditForm : Form
    {
        /// <summary>
        /// Скопированный изменяемый покупатель.
        /// </summary>
        private Customer _copiedCustomer;

        /// <summary>
        /// Возвращает или задает изменяемого покупателя.
        /// </summary>
        public Customer CurrentCustomer { get; set; }

        /// <summary>
        /// Создает объект типа <see cref="CustomersEditForm"/>.
        /// Заполняет все поля формы данными покупателя, которого нужно изменить
        /// и копирует их в новый экземпляр класса.
        /// </summary>
        /// <param name="customer">Покупатель, которого нужно изменить.</param>
        public CustomersEditForm(Customer customer)
        {
            InitializeComponent();
            _copiedCustomer = Customer.CopyCustomer(customer);
            IdTextBox.Text = customer.Id.ToString();
            FullNameTextBox.Text = customer.FullName;
            //AddressTextBox.Text = customer.Address;
        }

        /// <summary>
        /// При изменении текста FullNameTextBox пытается присвоить этот текст в свойство FullName элемента
        /// _copiedCustomer и красит FullNameTextBox в соответствии с валидацией.
        /// </summary>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FullNameTextBox.BackColor = Color.White;
                _copiedCustomer.FullName = FullNameTextBox.Text;
            }
            catch
            {
                FullNameTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// При изменении текста AddressTextBox пытается присвоить этот текст в свойство Address элемента
        /// _copiedCustomer и красит AddressTextBox в соответствии с валидацией.
        /// </summary>
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AddressTextBox.BackColor = Color.White;
                //_copiedCustomer.Address = AddressTextBox.Text;
            }
            catch
            {
                AddressTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// При нажатии на кнопку мзменения покупателя, если все поля экземпляра покупателя
        /// не пустые и значения допустимы, то передает его в свойство CurrentCustomer и закрывает форму.
        /// </summary>
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (_copiedCustomer.FullName == null
                || _copiedCustomer.Address == null)
            {
                return;
            }
            if (FullNameTextBox.BackColor == Color.LightPink
                || AddressTextBox.BackColor == Color.LightPink)
            {
                return;
            }
            CurrentCustomer = _copiedCustomer;
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// При нажатии на кнопку удаления покупателя удаляет покупателя и закрывает форму.
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
