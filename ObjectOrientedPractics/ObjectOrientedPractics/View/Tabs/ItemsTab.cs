using ObjectOrientedPractics.Model;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        private BindingList<Item> _items = new BindingList<Item>();

        /// <summary>
        /// 
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            ItemsListBox.DataSource = _items;
            ItemsListBox.DisplayMember = nameof(Item.DisplayInfo);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        private void UpdateItemInfo(Item item)
        {
            IdTextBox.Text = item.Id.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            InfoTextBox.Text = item.Info.ToString();
        }

        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(new Item());
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                _items.Add(editForm.CurrentItem);
            }
            ItemsListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// 
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = ItemsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _items.RemoveAt(selectedIndex);
                ItemsListBox.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void EditButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = ItemsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                EditForm editForm = new EditForm(_items[selectedIndex]);
                editForm.ShowDialog();
                if (editForm.DialogResult == DialogResult.OK)
                {
                    _items[selectedIndex] = editForm.CurrentItem;
                }
            }
            ItemsListBox.SelectedIndex = -1;
        }
    }
}
