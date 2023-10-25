using ObjectOrientedPractics.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Services;
using System.ComponentModel;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Содержит логику вкладки товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {      
        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Возвращает и задает список элементов класса Item.
        /// </summary>
        public BindingList<Item> Items { get; set; }

        /// <summary>
        /// Создает объект типа <see cref="ItemsTab"/>.
        /// Выводит в ItemsListBox только название товара.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            ItemsListBox.DisplayMember = nameof(Item.DisplayInfo);
        }

        /// <summary>
        /// Моментально отображает изменения в ListBox.
        /// </summary>
        private void UpdateDisplayMember()
        {
            ItemsListBox.DisplayMember = null;
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
        /// заполняет все текстовые поля значениями выбранного Item.
        /// Заполняет CategoryComboBox значениями перечисления.
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
                _currentItem = Items[ItemsListBox.SelectedIndex];
                UpdateItemInfo(_currentItem);
            }
            else
            {
                CategoryComboBox.Items.Clear();
                ClearItemInfo();
            }
        }

        /// <summary>
        /// При нажатии на кнопку создает товар с рандомными значениями
        /// и добавляет его в ItemsListBox.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.DataSource == null)
            {
                ItemsListBox.DataSource = Items;
            }
            Items.Add(ItemFactory.Randomize());
            ItemsListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// При нажатии на кнопку удаления товара удаляет выбранный товар из списка и из ItemsListBox.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = ItemsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                Items.RemoveAt(selectedIndex);
                ItemsListBox.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Присваивает значение из CostTextBox в свойство Cost товара.
        /// Если значение не валидное, то красит его в красный цвет.
        /// </summary>
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

        /// <summary>
        /// Присваивает значение из NameTextBox в свойство Name товара.
        /// Если значение не валидное, то красит его в красный цвет.
        /// </summary>
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
                UpdateDisplayMember();
            }
            catch
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Присваивает значение из InfoTextBox в свойство Info товара.
        /// Если значение не валидное, то красит его в красный цвет.
        /// </summary>
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

        /// <summary>
        /// Присваивает значение из CategoryComboBox в свойство Category товара.
        /// </summary>
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
