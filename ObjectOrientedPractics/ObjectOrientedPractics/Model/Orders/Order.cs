using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.ComponentModel;

namespace ObjectOrientedPractics.Model.Orders
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
        public Address Address { get; set; } = new Address();

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
        /// Возвращает и задает размер примененной скидки.
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Возвращает конечную стоимость заказа.
        /// </summary>
        public double Total
        {
            get
            {
                return Amount - DiscountAmount;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            Id = IdGenerator.GetNextId();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров в заказе.</param>
        public Order(Address address, BindingList<Item> items)
        {
            Id = IdGenerator.GetNextId();
            Date = DateTime.Now.ToString();
            OrderStatus = OrderStatus.New;
            Address.Index = address.Index;
            Address.Country = address.Country;
            Address.City = address.City;
            Address.Street = address.Street;
            Address.Building = address.Building;
            Address.Apartment = address.Apartment;
            for (int i = 0; i < items.Count; i++)
            {
                Items.Add(items[i]);
            }
        }
    }
}
