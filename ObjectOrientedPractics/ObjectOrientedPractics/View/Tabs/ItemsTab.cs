using ObjectOrientedPractics.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Содержит логику вкладки товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список элементов класса Item.
        /// </summary>
        private BindingList<Item> _items = new BindingList<Item>();

        /// <summary>
        /// Относительный путь к папке, где должен лежать файл json.
        /// </summary>
        private string _pathToJson =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ObjectOrientedPractics";

        /// <summary>
        /// Относительный путь к файлу json.
        /// </summary>
        private string _jsonPath =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ObjectOrientedPractics\\items.json";

        /// <summary>
        /// Создает объект типа <see cref="ItemsTab"/>.
        /// Если не существует файла json и папки, где он должен лежать, то создаем их.
        /// Загружает все ранее созданные экземпляры класса Item и заполняет их данными ItemsListBox.
        /// </summary>
        public ItemsTab()
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
                Item tempItem = serializer.Deserialize<Item>(reader);
                _items.Add(tempItem);
            }
            reader.Close();
            ItemsListBox.DataSource = _items;
            ItemsListBox.DisplayMember = nameof(Item.DisplayInfo);
        }

        /// <summary>
        /// Обновляет текстовые поля выбранного товара.
        /// </summary>
        /// <param name="item">Товар, текстовые поля которого необходимо обновить.</param>
        private void UpdateItemInfo(Item item)
        {
            IdTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            InfoTextBox.Text = item.Info;
        }

        /// <summary>
        /// Очищает все текстовые поля и перекрашивает их в исходный цвет.
        /// </summary>
        private void ClearItemInfo()
        {
            IdTextBox.Clear();
            CostTextBox.Clear();
            CostTextBox.BackColor = Color.White;
            NameTextBox.Clear();
            NameTextBox.BackColor = Color.White;
            InfoTextBox.Clear();
            InfoTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// При изменении выбранного элемента ItemsListBox
        /// заполняет все текстовые поля значениями выбранного _item.
        /// Если товар не выбран, то очищает все текстовые поля.
        /// </summary>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                UpdateItemInfo(_items[ItemsListBox.SelectedIndex]);
            }
            else
            {
                ClearItemInfo();
            }
        }

        /// <summary>
        /// При нажатии на кнопку добавления товара открывает соответствующую форму
        /// и добавляет созданный товар в список _items.
        /// Записывает новый товар в файл json.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            ItemsEditForm editForm = new ItemsEditForm(new Item());
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                _items.Add(editForm.CurrentItem);
            }
            ItemsListBox.SelectedIndex = -1;
            File.WriteAllText(_jsonPath, string.Empty);
            for (int i = 0; i < _items.Count; i++)
            {
                File.AppendAllText(_jsonPath, JsonConvert.SerializeObject(_items[i]));
            }
        }

        /// <summary>
        /// При нажатии на кнопку удаления товара удаляет выбранный товар из списка и из ItemsListBox.
        /// Также удаляет выбранный товар из файла json.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = ItemsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _items.RemoveAt(selectedIndex);
                ItemsListBox.SelectedIndex = -1;
                File.WriteAllText(_jsonPath, string.Empty);
                for (int i = 0; i < _items.Count; i++)
                {
                    File.AppendAllText(_jsonPath, JsonConvert.SerializeObject(_items[i]));
                }
            }
        }

        /// <summary>
        /// При нажатии на кнопку изменения товара открывает соответствующую форму
        /// и изменяет товар в списке _items.
        /// Записывает измененный товар в файл json.
        /// </summary>
        private void EditButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = ItemsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                ItemsEditForm editForm = new ItemsEditForm(_items[selectedIndex]);
                editForm.ShowDialog();
                if (editForm.DialogResult == DialogResult.OK)
                {
                    _items[selectedIndex] = editForm.CurrentItem;
                }
            }
            ItemsListBox.SelectedIndex = -1;
            File.WriteAllText(_jsonPath, string.Empty);
            for (int i = 0; i < _items.Count; i++)
            {
                File.AppendAllText(_jsonPath, JsonConvert.SerializeObject(_items[i]));
            }
        }
    }
}
