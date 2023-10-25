using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public List<Item> Items {  get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Customer> Customers { get; set; }

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
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = CustomerComboBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                CurrentCustomer = Customers[selectedIndex];
                for (int i = 0; i < CurrentCustomer.Cart.Items.Count; i++)
                {
                    CartListBox.Items.Add(CurrentCustomer.Cart.Items[i]);
                }
            }
            else
            {
                CartListBox.Items.Clear();
            }
        }

        private void CartsTab_Enter(object sender, EventArgs e)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                ItemsListBox.Items.Add(Items[i]);
            }
            for (int i = 0; i < Customers.Count; i++)
            {
                CustomerComboBox.Items.Add(Customers[i]);
            }
        }
    }
}
