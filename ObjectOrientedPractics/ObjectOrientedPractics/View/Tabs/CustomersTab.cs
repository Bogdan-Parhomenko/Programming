using Newtonsoft.Json;
using ObjectOrientedPractics.Model;
using System;
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
        private BindingList<Customer> _customers = new BindingList<Customer>();

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
            if (!Directory.Exists(_pathToJson))
            {
                Directory.CreateDirectory(_pathToJson);
            }
            if (!File.Exists(_jsonPath))
            {
                FileStream fileStream = new FileStream(_jsonPath, FileMode.CreateNew);
                fileStream.Close();
            }
            JsonTextReader reader = new JsonTextReader(new StreamReader(_jsonPath));
            reader.SupportMultipleContent = true;
            while (true)
            {
                if (!reader.Read())
                {
                    break;
                }
                JsonSerializer serializer = new JsonSerializer();
                Customer tempCustomer = serializer.Deserialize<Customer>(reader);
                _customers.Add(tempCustomer);
            }
            reader.Close();
            CustomersListBox.DataSource = _customers;
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
            AddressTextBox.Text = customer.Address;
        }

        /// <summary>
        /// Очищает все текстовые поля и перекрашивает их в исходный цвет.
        /// </summary>
        private void ClearCustomerInfo()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            FullNameTextBox.BackColor = Color.White;
            AddressTextBox.Clear();
            AddressTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// При изменении выбранного элемента CustomersListBox
        /// заполняет все текстовые поля значениями выбранного _customers.
        /// Если покупатель не выбран, то очищает все текстовые поля.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                UpdateCustomerInfo(_customers[CustomersListBox.SelectedIndex]);
            }
            else
            {
                ClearCustomerInfo();
            }
        }

        /// <summary>
        /// При нажатии на кнопку добавления покупателя открывает соответствующую форму
        /// и добавляет созданного покупателя в список _customers.
        /// Записывает нового покупателя в файл json.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            CustomersEditForm editForm = new CustomersEditForm(new Customer());
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                _customers.Add(editForm.CurrentCustomer);
            }
            CustomersListBox.SelectedIndex = -1;
            File.WriteAllText(_jsonPath, string.Empty);
            for (int i = 0; i < _customers.Count; i++)
            {
                File.AppendAllText(_jsonPath, JsonConvert.SerializeObject(_customers[i]));
            }
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
                _customers.RemoveAt(selectedIndex);
                CustomersListBox.SelectedIndex = -1;
                File.WriteAllText(_jsonPath, string.Empty);
                for (int i = 0; i < _customers.Count; i++)
                {
                    File.AppendAllText(_jsonPath, JsonConvert.SerializeObject(_customers[i]));
                }
            }
        }

        /// <summary>
        /// При нажатии на кнопку изменения покупателя открывает соответствующую форму
        /// и изменяет покупателя в списке _customers.
        /// Записывает измененного покупателя в файл json.
        /// </summary>
        private void EditButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = CustomersListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                CustomersEditForm editForm = new CustomersEditForm(_customers[selectedIndex]);
                editForm.ShowDialog();
                if (editForm.DialogResult == DialogResult.OK)
                {
                    _customers[selectedIndex] = editForm.CurrentCustomer;
                }
            }
            CustomersListBox.SelectedIndex = -1;
            File.WriteAllText(_jsonPath, string.Empty);
            for (int i = 0; i < _customers.Count; i++)
            {
                File.AppendAllText(_jsonPath, JsonConvert.SerializeObject(_customers[i]));
            }
        }
    }
}
