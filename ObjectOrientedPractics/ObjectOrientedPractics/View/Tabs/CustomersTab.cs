using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Содержит логику вкладки покупателей.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Возвращает и задает список элементов класса Customer.
        /// </summary>
        public List<Customer> Customers;

        /// <summary>
        /// Создает объект типа <see cref="CustomersTab"/>.
        /// Выводит в CustomersListBox только имена покупателей.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            CustomersListBox.DisplayMember = nameof(Customer.DisplayInfo);
        }

        /// <summary>
        /// Обновляет текстовые поля выбранного покупателя.
        /// </summary>
        /// <param name="customer">Покупатель, текстовые поля которого необходимо обновить.</param>
        private void UpdateCustomerInfo(Customer customer)
        {
            IdTextBox.Text = customer.Id.ToString();
            FullNameTextBox.Text = customer.FullName;
        }

        /// <summary>
        /// Очищает все текстовые поля и перекрашивает их в исходный цвет.
        /// </summary>
        private void ClearCustomerInfo()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            FullNameTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// При изменении выбранного элемента CustomersListBox
        /// заполняет все текстовые поля значениями выбранного Customers
        /// и передает в AddressControl значение поля address выбранного объекта.
        /// Если покупатель не выбран, то очищает все текстовые поля.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                _currentCustomer = Customers[CustomersListBox.SelectedIndex];
                UpdateCustomerInfo(_currentCustomer);
                AddressControl.Address = _currentCustomer.Address;
            }
            else
            {
                ClearCustomerInfo();
                AddressControl.ClearAllTextBoxes(true);
            }
        }

        /// <summary>
        /// При нажатии на кнопку создает покупателя с рандомными значениями
        /// и добавляет его в CustomersListBox.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            var addedCustomerId = Customers.Count;
            Customers.Add(CustomerFactory.Randomize());
            CustomersListBox.Items.Add(Customers[addedCustomerId]);
        }

        /// <summary>
        /// При нажатии на кнопку удаления покупателя удаляет выбранного покупателя из списка и из CustomersListBox.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = CustomersListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                Customers.RemoveAt(selectedIndex);
                CustomersListBox.Items.RemoveAt(selectedIndex);
            }
        }

        /// <summary>
        /// Присваивает значение из FullNameTextBox в свойство FullName покупателя.
        /// Если значение не валидное, то красит его в красный цвет.
        /// </summary>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                FullNameTextBox.BackColor = Color.White;
                _currentCustomer.FullName = FullNameTextBox.Text;
                CustomersListBox.SelectedIndexChanged -= CustomersListBox_SelectedIndexChanged;
                CustomersListBox.Items[CustomersListBox.SelectedIndex] =
                    Customers[CustomersListBox.SelectedIndex];
                CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            }
            catch
            {
                FullNameTextBox.BackColor = Color.LightPink;
            }
        }
    }
}
