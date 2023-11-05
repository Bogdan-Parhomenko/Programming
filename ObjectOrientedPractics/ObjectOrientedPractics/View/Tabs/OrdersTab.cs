using ObjectOrientedPractics.Model;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        public BindingList<Customer> Customers { get; set; }

        private Order CurrentOrder { get; set; }

        private BindingList<Order> Orders { get; set; } = new BindingList<Order>();

        public OrdersTab()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            Orders.Clear();
            OrdersDataGridView.ColumnCount = 6;
            OrdersDataGridView.Columns[0].Name = "Id";
            OrdersDataGridView.Columns[1].Name = "Created";
            OrdersDataGridView.Columns[2].Name = "Order Status";
            OrdersDataGridView.Columns[3].Name = "Customer Full Name";
            OrdersDataGridView.Columns[4].Name = "Delivery Address";
            OrdersDataGridView.Columns[5].Name = "Amount";
            OrdersDataGridView.Rows.Clear();
            UpdateOrders();
        }

        private void UpdateOrders()
        {
            for (int i = 0; i < Customers.Count; i++)
            {
                for (int j = 0; j < Customers[i].Order.Count; j++)
                {
                    Orders.Add(Customers[i].Order[j]);
                    string[] row = {
                        Customers[i].Order[j].Id.ToString(),
                        Customers[i].Order[j].Date,
                        Customers[i].Order[j].OrderStatus.ToString(),
                        Customers[i].FullName,
                        AddressToString(Customers[i].Order[j].Address),
                        Customers[i].Order[j].Amount.ToString()};
                    OrdersDataGridView.Rows.Add(row);
                }
            }
        }

        private string AddressToString(Address address)
        {
            return $"{address.Index} {address.Country} {address.City} {address.Street} {address.Building} {address.Apartment}";
        }

        private void UpdateOrderInfo(Order order)
        {
            IdTextBox.Text = order.Id.ToString();
            DataTextBox.Text = order.Date;
            StatusComboBox.Text = order.OrderStatus.ToString();
            AddressControl.Address = order.Address;
            OrderItemsListBox.DataSource = order.Items;
            OrderItemsListBox.DisplayMember = nameof(Item.DisplayInfo);
            RefreshAmount();
        }

        private void ClearOrderInfo()
        {
            IdTextBox.Clear();
            DataTextBox.Clear();
            OrderItemsListBox.DataSource = null;
        }

        private void RefreshAmount()
        {
            TotalAmountLabel.Text = CurrentOrder.Amount.ToString();
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.SelectedRows.Count != 0)
            {
                if (StatusComboBox.Items.Count == 0)
                {
                    StatusComboBox.Items.AddRange(Enum.GetNames(typeof(OrderStatus)));
                }
                CurrentOrder = Orders[OrdersDataGridView.SelectedRows[0].Index];
                UpdateOrderInfo(CurrentOrder);
            }
            else
            {
                StatusComboBox.Items.Clear();
                AddressControl.ClearAllTextBoxes(true);
                ClearOrderInfo();
                CurrentOrder = null;
                TotalAmountLabel.Text = "0";
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
