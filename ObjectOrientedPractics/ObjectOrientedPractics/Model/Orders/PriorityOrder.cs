using System;
using System.ComponentModel;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Хранит данные о приоритетном заказе.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Возвращает и задает желаемую дату заказа.
        /// </summary>
        public DateTime DesiredDeliveryDate { get; set; }

        /// <summary>
        /// Возвращает и задает желаемое время заказа.
        /// </summary>
        public string  DesiredDeliveryTime { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров в заказе.</param>
        public PriorityOrder(Address address, BindingList<Item> items) : base(address, items)
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров в заказе.</param>
        /// <param name="desiredDeliveryDate">Желаемая дата заказа.</param>
        /// <param name="desiredDeliveryTime">Желаемое время заказа.</param>
        public PriorityOrder(Address address, BindingList<Item> items, DateTime desiredDeliveryDate, string desiredDeliveryTime) : base(address, items)
        {
            DesiredDeliveryDate = desiredDeliveryDate;
            DesiredDeliveryTime = desiredDeliveryTime;
        }
    }
}
