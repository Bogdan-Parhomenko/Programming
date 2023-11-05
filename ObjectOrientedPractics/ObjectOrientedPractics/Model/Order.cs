using ObjectOrientedPractics.Services;
using System;
using System.ComponentModel;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о заказе.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Общая стоимость всех товаров в заказе.
        /// </summary>
        private double _amount;

        /// <summary>
        /// Возвращает уникальный идентификатор заказа.
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Возвращает дату создания заказа.
        /// </summary>
        public string Date { get; private set; }

        /// <summary>
        /// Возвращает и задает статус заказа.
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Возвращает и задает адрес доставки.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Возвращает и задает список товаров в заказе.
        /// </summary>
        public BindingList<Item> Items { get; set; } = new BindingList<Item>();

        /// <summary>
        /// Возвращает общую стоимость товаров в заказе.
        /// </summary>
        public double Amount
        {
            get
            {
                _amount = 0.0;

                if (Items == null)
                {
                    return _amount;
                }

                for (int i = 0; i < Items.Count; i++)
                {
                    _amount += Items[i].Cost;
                }
                return _amount;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            Id = IdGenerator.GetNextId();
        }

        public Order(Address address, BindingList<Item> items)
        {
            Id = IdGenerator.GetNextId();
            Date = DateTime.Now.ToString();
            OrderStatus = OrderStatus.New;
            Address = address;
            for (int i = 0; i < items.Count; i++)
            {
                Items.Add(items[i]);
            }
        }
    }
}
