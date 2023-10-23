using Newtonsoft.Json;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Содержит логику вкладки покупателей.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список элементов класса Customer.
        /// </summary>
        private List<Customer> _customers;

        private Customer _currentCustomer;

        public List<Customer> Customers;

        /// <summary>
        /// Относительный путь к папке, где должен лежать файл json.
        /// </summary>
        private string _pathToJson =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ObjectOrientedPractics";

        /// <summary>
        /// Относительный путь к файлу json.
        /// </summary>
        private string _jsonPath =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ObjectOrientedPractics\\customers.json";

        /// <summary>
        /// Создает объект типа <see cref="CustomersTab"/>.
        /// Если не существует файла json и папки, где он должен лежать, то создаем их.
        /// Загружает все ранее созданные экземпляры класса Customer и заполняет их данными CustomersListBox.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            //if (!Directory.Exists(_pathToJson))
            //{
            //    Directory.CreateDirectory(_pathToJson);
            //}
            //if (!File.Exists(_jsonPath))
            //{
            //    FileStream fileStream = new FileStream(_jsonPath, FileMode.CreateNew);
            //    fileStream.Close();
            //}
            //JsonTextReader reader = new JsonTextReader(new StreamReader(_jsonPath));
            //reader.SupportMultipleContent = true;
            //while (true)
            //{
            //    if (!reader.Read())
            //    {
            //        break;
            //    }
            //    JsonSerializer serializer = new JsonSerializer();
            //    Customer tempCustomer = serializer.Deserialize<Customer>(reader);
            //    Customers.Add(tempCustomer);
            //}
            //reader.Close();
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
        /// заполняет все текстовые поля значениями выбранного Customers.
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
        /// При нажатии на кнопку добавления покупателя открывает соответствующую форму
        /// и добавляет созданного покупателя в список Customers.
        /// Записывает нового покупателя в файл json.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            var addedCustomerId = Customers.Count;
            Customers.Add(CustomerFactory.Randomize());
            CustomersListBox.Items.Add(Customers[addedCustomerId]);
            //File.WriteAllText(_jsonPath, string.Empty);
            //for (int i = 0; i < Customers.Count; i++)
            //{
            //    File.AppendAllText(_jsonPath, JsonConvert.SerializeObject(Customers[i]));
            //}
        }

        /// <summary>
        /// При нажатии на кнопку удаления покупателя удаляет выбранного покупателя из списка и из CustomersListBox.
        /// Также удаляет выбранного покупателя из файла json.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = CustomersListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                Customers.RemoveAt(selectedIndex);
                CustomersListBox.Items.RemoveAt(selectedIndex);
                //File.WriteAllText(_jsonPath, string.Empty);
                //for (int i = 0; i < Customers.Count; i++)
                //{
                //    File.AppendAllText(_jsonPath, JsonConvert.SerializeObject(Customers[i]));
                //}
            }
        }

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
