using ObjectOrientedPractics.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using ObjectOrientedPractics.Services;
using System.ComponentModel;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Содержит логику вкладки товаров.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Событие изменения списка товаров.
        /// </summary>
        public event EventHandler<EventArgs> ItemsChanged;

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Возвращает и задает список элементов класса Item.
        /// </summary>
        public BindingList<Item> Items { get; set; }

        /// <summary>
        /// Возвращает и задает список элементов класса Item при поиске подстроки.
        /// </summary>
        public BindingList<Item> DisplayedItems { get; set; }

        /// <summary>
        /// Создает объект типа <see cref="ItemsTab"/>.
        /// Выводит в ItemsListBox только название товара.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            ItemsListBox.DisplayMember = nameof(Item.DisplayInfo);
            OrderByComboBox.Items.Add("Name");
            OrderByComboBox.Items.Add("Cost (Ascending)");
            OrderByComboBox.Items.Add("Cost (Descending)");
            OrderByComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// При переходе на эту вкладку обновляет все элементы управления актуальными значениями.
        /// </summary>
        public void RefreshData()
        {
            FindTextBox.Clear();
            DisplayedItems = null;
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = Items;
            ItemsListBox.DisplayMember = nameof(Item.DisplayInfo);
            OrderByComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Обновляет данные ListBox в зависимости от фильтрации.
        /// </summary>
        public void UpdateDisplayedItems()
        {
            DisplayedItems = DataTools.ItemsFiltering(Items, FindTextBox.Text, (x1, x2) => { return x1.Name.Contains(x2); });
            var selectedIndex = DisplayedItems.IndexOf(_currentItem);
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = DisplayedItems;
            ItemsListBox.SelectedIndex = selectedIndex;
            UpdateDisplayMember();
        }

        /// <summary>
        /// Сортирует список товаров.
        /// </summary>
        public void UpdateOrderItems()
        {
            if (OrderByComboBox.SelectedIndex == 0)
            {
                DataTools.SortItems(Items, DataTools.CompareName);
            }
            else if (OrderByComboBox.SelectedIndex == 1)
            {
                DataTools.SortItems(Items, DataTools.CompareAscendingCost);
            }
            else if (OrderByComboBox.SelectedIndex == 2)
            {
                DataTools.SortItems(Items, DataTools.CompareDescendingCost);
            }
            UpdateDisplayedItems();
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
                if (DisplayedItems == null)
                {
                    _currentItem = Items[ItemsListBox.SelectedIndex];
                }
                else
                {
                    _currentItem = Items[Items.IndexOf(DisplayedItems[ItemsListBox.SelectedIndex])];
                }
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
            var args = new EventArgs();
            ItemsChanged?.Invoke(this, args);
            UpdateOrderItems();
            ItemsListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// При нажатии на кнопку удаления товара удаляет выбранный товар из списка и из ItemsListBox.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = Items.IndexOf(DisplayedItems[ItemsListBox.SelectedIndex]);
            if (selectedIndex != -1)
            {
                Items.RemoveAt(selectedIndex);
                var args = new EventArgs();
                ItemsChanged?.Invoke(this, args);
                UpdateOrderItems();
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
                if (_currentItem.Cost != Double.Parse(CostTextBox.Text))
                {
                    _currentItem.Cost = Double.Parse(CostTextBox.Text);
                    var args = new EventArgs();
                    ItemsChanged?.Invoke(this, args);
                }
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
                if (_currentItem.Name != NameTextBox.Text)
                {
                    _currentItem.Name = NameTextBox.Text;
                    var args = new EventArgs();
                    ItemsChanged?.Invoke(this, args);
                }
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
                if (_currentItem.Info != InfoTextBox.Text)
                {
                    _currentItem.Info = InfoTextBox.Text;
                    var args = new EventArgs();
                    ItemsChanged?.Invoke(this, args);
                }
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
            if (_currentItem.Category != (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text))
            {
                _currentItem.Category = (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text);
                var args = new EventArgs();
                ItemsChanged?.Invoke(this, args);
            }
        }

        /// <summary>
        /// Фильтрует список товаров по строке.
        /// </summary>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateDisplayedItems();
            if (DisplayedItems.Count == 0)
            {
                ClearItemInfo();
            }
        }

        /// <summary>
        /// Сортирует список товаров.
        /// </summary>
        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Items == null)
            {
                return;
            }
            UpdateOrderItems();
        }
    }
}
