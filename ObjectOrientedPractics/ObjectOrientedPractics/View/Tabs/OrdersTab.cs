using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Содержит логику вкладки заказов.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Возвращает и задает список объектов класса <see cref="Customer"/>.
        /// </summary>
        public BindingList<Customer> Customers { get; set; }

        /// <summary>
        /// Возвращает и задает выбранный объект класса <see cref="Order"/>.
        /// </summary>
        private Order CurrentOrder { get; set; }

        /// <summary>
        /// Возвращает и задает выбранный объект класса <see cref="PriorityOrder"/>.
        /// </summary>
        private PriorityOrder CurrentPriorityOrder { get; set; }

        /// <summary>
        /// Возвращает и задает список объектов класса <see cref="Order"/>.
        /// </summary>
        private BindingList<Order> Orders { get; set; } = new BindingList<Order>();

        /// <summary>
        /// Создает объект типа <see cref="OrdersTab"/> и инициализирует столбцы таблицы.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
            OrdersDataGridView.ColumnCount = 6;
            OrdersDataGridView.Columns[0].Name = "Id";
            OrdersDataGridView.Columns[1].Name = "Created";
            OrdersDataGridView.Columns[2].Name = "Order Status";
            OrdersDataGridView.Columns[3].Name = "Customer Full Name";
            OrdersDataGridView.Columns[4].Name = "Delivery Address";
            OrdersDataGridView.Columns[5].Name = "Amount";
            foreach (DataGridViewColumn column in OrdersDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        /// <summary>
        /// При переходе на эту вкладку заполняет таблицу актуальными знавениями.
        /// </summary>
        public void RefreshData()
        {
            Orders.Clear();
            OrdersDataGridView.Rows.Clear();
            UpdateOrders();
        }

        /// <summary>
        /// Инициализирует список заказов Orders и заполняет таблицу OrdersDataGridView.
        /// </summary>
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

        /// <summary>
        /// Конвертирует экземпляр класса <see cref="Address"/> в строку.
        /// </summary>
        /// <param name="address">Конвертируемый адрес.</param>
        /// <returns></returns>
        private string AddressToString(Address address)
        {
            return $"{address.Index} {address.Country} {address.City} {address.Street} {address.Building} {address.Apartment}";
        }

        /// <summary>
        /// Инициализирует все элементы управления данными выбранного заказа.
        /// </summary>
        /// <param name="order">Выбранный заказ.</param>
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

        /// <summary>
        /// Очищает элементы управления.
        /// </summary>
        private void ClearOrderInfo()
        {
            IdTextBox.Clear();
            DataTextBox.Clear();
            OrderItemsListBox.DataSource = null;
        }

        /// <summary>
        /// Высчитывает актуальную стоимость товаров в корзине.
        /// </summary>
        private void RefreshAmount()
        {
            TotalAmountLabel.Text = CurrentOrder.Amount.ToString();
        }

        /// <summary>
        /// При выборе заказа инициализирует все элементы управления.
        /// Работает с приоритетными и не приоритетными заказами по разному.
        /// </summary>
        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.SelectedRows.Count != 0)
            {
                if (Orders[OrdersDataGridView.SelectedRows[0].Index] is PriorityOrder priorityOrder)
                {
                    CurrentOrder = priorityOrder;
                    CurrentPriorityOrder = priorityOrder;
                    PriorityOptionsLabel.Visible = true;
                    DeliveryTimeLabel.Visible = true;
                    DeliveryTimeComboBox.Visible = true;
                    DeliveryTimeComboBox.Text = CurrentPriorityOrder.DesiredDeliveryTime;
                }
                else
                {
                    CurrentOrder = Orders[OrdersDataGridView.SelectedRows[0].Index];
                    CurrentPriorityOrder = null;
                    PriorityOptionsLabel.Visible = false;
                    DeliveryTimeLabel.Visible = false;
                    DeliveryTimeComboBox.Visible = false;
                }
                if (StatusComboBox.Items.Count == 0)
                {
                    StatusComboBox.Items.AddRange(Enum.GetNames(typeof(OrderStatus)));
                }
                UpdateOrderInfo(CurrentOrder);
            }
            else
            {
                StatusComboBox.Items.Clear();
                ClearOrderInfo();
                AddressControl.ClearAllTextBoxes(true);
                CurrentOrder = null;
                TotalAmountLabel.Text = "0";
            }
        }

        /// <summary>
        /// При изменении значения StatusComboBox обновляет статус заказа.
        /// </summary>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentOrder.OrderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), StatusComboBox.Text);
        }

        /// <summary>
        /// При изменении значения DeliveryTimeComboBox обновляет желаемое время доставки заказа.
        /// </summary>
        public void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentPriorityOrder.DesiredDeliveryTime = DeliveryTimeComboBox.Text;
        }
    }
}
