using System.ComponentModel;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о всех списках.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private BindingList<Item> _items;

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private BindingList<Customer> _customers;

        /// <summary>
        /// Возвращает и задает список товаров. Не может быть равен null.
        /// </summary>
        public BindingList<Item> Items
        {
            get => _items;
            set
            {
                _items = value ?? new BindingList<Item>();
            }
        }

        /// <summary>
        /// Возвращает и задает список покупателей. Не может быть равен null.
        /// </summary>
        public BindingList<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value ?? new BindingList<Customer>();
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Store"/>.
        /// </summary>
        public Store()
        {
            Items = new BindingList<Item>();
            Customers = new BindingList<Customer>();
        }
    }
}
