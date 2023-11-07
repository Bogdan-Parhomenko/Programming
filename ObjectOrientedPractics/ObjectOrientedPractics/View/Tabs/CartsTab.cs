using ObjectOrientedPractics.Model;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Содержит логику вкладки корзин покупателей.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Возвращает и задает список объектов класса <see cref="Item"/>.
        /// </summary>
        public BindingList<Item> Items {  get; set; }

        /// <summary>
        /// Возвращает и задает список объектов класса <see cref="Customer"/>.
        /// </summary>
        public BindingList<Customer> Customers { get; set; }

        /// <summary>
        /// Возвращает и задает выбранный объект класса <see cref="Customer"/>.
        /// </summary>
        private Customer CurrentCustomer { get; set; }

        /// <summary>
        /// Создает объект типа <see cref="CartsTab"/>.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// При переходе на эту вкладку обновляет все элементы управления актуальными значениями.
        /// </summary>
        public void RefreshData()
        {
            ItemsListBox.DataSource = null;
            CustomerComboBox.DataSource = null;
            ItemsListBox.DisplayMember = nameof(Item.DisplayInfo);
            CustomerComboBox.DisplayMember = nameof(Customer.DisplayInfo);
            ItemsListBox.DataSource = Items;
            ItemsListBox.SelectedIndex = -1;
            CustomerComboBox.DataSource = Customers;
            CustomerComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Высчитывает актуальную стоимость товаров в корзине.
        /// </summary>
        private void RefreshAmount()
        {
            TotalAmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
        }

        /// <summary>
        /// При выборе покупателя заполняет CartListBox товарами корзины покупателя и обновляет их стоимость.
        /// </summary>
        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = CustomerComboBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                CurrentCustomer = Customers[selectedIndex];
                CartListBox.DataSource = CurrentCustomer.Cart.Items;
                CartListBox.DisplayMember = nameof(Item.DisplayInfo);
                RefreshAmount();
            }
            else
            {
                CurrentCustomer = null;
                CartListBox.DataSource = null;
                TotalAmountLabel.Text = "0";
            }
        }

        /// <summary>
        /// Добавляет товар в корзину покупателя и обновляет ее стоимость.
        /// </summary>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1 && CurrentCustomer != null)
            {
                CurrentCustomer.Cart.Items.Add(Items[ItemsListBox.SelectedIndex]);
                RefreshAmount();
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Удаляет товар из корзины покупателя и обновляет ее стоимость.
        /// </summary>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
                RefreshAmount();
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Очищает корзину покупателя и обновляет ее стоимость.
        /// </summary>
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer != null)
            {
                CurrentCustomer.Cart.Items.Clear();
                RefreshAmount();
            }
        }

        /// <summary>
        /// Создает заказ <see cref="Order"/>, очищает корзину покупателя и обновляет ее стоимость.
        /// </summary>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer.IsPriority)
            {
                CurrentCustomer.Order.Add(new PriorityOrder(CurrentCustomer.Address, CurrentCustomer.Cart.Items));
            }
            else
            {
                CurrentCustomer.Order.Add(new Order(CurrentCustomer.Address, CurrentCustomer.Cart.Items));
            }
            CurrentCustomer.Cart.Items.Clear();
            RefreshAmount();
        }
    }
}
