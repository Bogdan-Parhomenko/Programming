using ObjectOrientedPractics.Model;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        public BindingList<Item> Items {  get; set; }

        /// <summary>
        /// 
        /// </summary>
        public BindingList<Customer> Customers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private Customer CurrentCustomer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
            ItemsListBox.DisplayMember = nameof(Item.DisplayInfo);
            CustomerComboBox.DisplayMember = nameof(Customer.DisplayInfo);
        }

        public void RefreshData()
        {
            ItemsListBox.DataSource = Items;
            ItemsListBox.SelectedIndex = -1;
            CustomerComboBox.DataSource = Customers;
            CustomerComboBox.SelectedIndex = -1;
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = CustomerComboBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                CurrentCustomer = Customers[selectedIndex];
                CartListBox.DataSource = CurrentCustomer.Cart.Items;
                CartListBox.DisplayMember = nameof(Item.DisplayInfo);
                TotalAmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
            else
            {
                CurrentCustomer = null;
                CartListBox.DataSource = null;
                TotalAmountLabel.Text = "0";
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1 && CurrentCustomer != null)
            {
                CurrentCustomer.Cart.Items.Add(Items[ItemsListBox.SelectedIndex]);
                TotalAmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
            else
            {
                return;
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
                TotalAmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
            else
            {
                return;
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer != null)
            {
                CurrentCustomer.Cart.Items.Clear();
                TotalAmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
            }
        }
    }
}
