using System.Collections.Generic;

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
        private List<Item> _items;

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Возвращает и задает список товаров. Не может быть равен null.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value ?? new List<Item>();
            }
        }

        /// <summary>
        /// Возвращает и задает список покупателей. Не может быть равен null.
        /// </summary>
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value ?? new List<Customer>();
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Store"/>.
        /// </summary>
        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
        }
    }
}
