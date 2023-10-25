using ObjectOrientedPractics.Model;
using System.Windows.Forms;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Содержит логику главного окна.
    /// </summary>
    public partial class MainForm : Form
    {
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
        }
    }
}
