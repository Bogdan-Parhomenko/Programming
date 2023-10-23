using ObjectOrientedPractics.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using ObjectOrientedPractics.Services;
using System.Collections.Generic;

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
        private List<Item> _items = new List<Item>();

        private Item _currentItem;

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
            //    Item tempItem = serializer.Deserialize<Item>(reader);
            //    _items.Add(tempItem);
            //}
            //reader.Close();
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
            CategoryComboBox.Text = item.Category.ToString();
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
                if (CategoryComboBox.Items.Count == 0)
                {
                    CategoryComboBox.Items.AddRange(Enum.GetNames(typeof(Category)));
                }
                _currentItem = _items[ItemsListBox.SelectedIndex];
                UpdateItemInfo(_currentItem);
            }
            else
            {
                CategoryComboBox.Items.Clear();
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
            var addedItemId = _items.Count;
            _items.Add(ItemFactory.Randomize());
            ItemsListBox.Items.Add(_items[addedItemId]);
            //File.WriteAllText(_jsonPath, string.Empty);
            //for (int i = 0; i < _items.Count; i++)
            //{
            //    File.AppendAllText(_jsonPath, JsonConvert.SerializeObject(_items[i]));
            //}
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
                ItemsListBox.Items.RemoveAt(selectedIndex);
                //File.WriteAllText(_jsonPath, string.Empty);
                //for (int i = 0; i < _items.Count; i++)
                //{
                //    File.AppendAllText(_jsonPath, JsonConvert.SerializeObject(_items[i]));
                //}
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                CostTextBox.BackColor = Color.White;
                _currentItem.Cost = Double.Parse(CostTextBox.Text);
            }
            catch
            {
                CostTextBox.BackColor = Color.LightPink;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                NameTextBox.BackColor = Color.White;
                _currentItem.Name = NameTextBox.Text;
                ItemsListBox.SelectedIndexChanged -= ItemsListBox_SelectedIndexChanged;
                ItemsListBox.Items[ItemsListBox.SelectedIndex] =
                    _items[ItemsListBox.SelectedIndex];
                ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            }
            catch
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                InfoTextBox.BackColor = Color.White;
                _currentItem.Info = InfoTextBox.Text;
            }
            catch
            {
                InfoTextBox.BackColor = Color.LightPink;
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                return;
            }
            _currentItem.Category = (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text);
        }
    }
}
