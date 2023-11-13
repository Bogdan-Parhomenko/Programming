﻿using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Содержит логику главного окна.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Хранит информацию о товарах и покупателях.
        /// </summary>
        private Store _store = new Store();

        /// <summary>
        /// Создает объект типа <see cref="MainForm"/>.
        /// Передает списки товаров и покупателей из Store в Items и Customers.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
            OrdersTab.Customers = _store.Customers;
        }

        /// <summary>
        /// При переходе на вкладку обновляет ее актуальными данными.
        /// </summary>
        private void TabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (TabControl.SelectedIndex == 0)
            {
                ItemsTab.RefreshData();
            }
            else if (TabControl.SelectedIndex == 1)
            {
                CustomersTab.RefreshData();
            }
            else if (TabControl.SelectedIndex == 2)
            {
                CartsTab.RefreshData();
            }
            else if (TabControl.SelectedIndex == 3)
            {
                OrdersTab.RefreshData();
            }
        }
    }
}
