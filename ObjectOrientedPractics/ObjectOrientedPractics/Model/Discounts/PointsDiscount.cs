using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Хранит данные о накопительно-бальной скидке.
    /// </summary>
    public class PointsDiscount : IDiscount
    {
        /// <summary>
        /// Количество накопленных баллов.
        /// </summary>
        private int _accumulatedPoints;

        /// <summary>
        /// Возвращает и задает количество накопленных баллов. Не может быть меньше 0.
        /// </summary>
        public int AccumulatedPoints
        {
            get => _accumulatedPoints;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Количество накопленных баллов не божеть быть отрицательным.");
                }
                _accumulatedPoints = value;
            }
        }

        /// <summary>
        /// Возвращает строку информации о баллах.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная – {AccumulatedPoints} баллов";
            }
        }

        /// <summary>
        /// Расчитывает размер скидки для товаров.
        /// </summary>
        /// <param name="items">Список товаров, которые подлежат скидке.</param>
        /// <returns>Возвращает размер скидки.</returns>
        public double Calculate(List<Item> items)
        {
            var totalCost = 0.0;
            foreach (var item in items)
            {
                totalCost += item.Cost;
            }
            totalCost *= 0.3;
            if (AccumulatedPoints >= (int)totalCost)
            {
                return (int)totalCost;
            }
            else
            {
                return AccumulatedPoints;
            }
        }

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        /// <param name="items">Список товаров, которые подлежат скидке.</param>
        /// <returns>Возвращает размер скидки.</returns>
        public double Apply(List<Item> items)
        {
            var discount = Calculate(items);
            foreach (var item in items)
            {
                item.Cost -= discount / items.Count;
            }
            AccumulatedPoints -= (int)discount;
            return (int)discount;
        }

        /// <summary>
        /// Добавляет скидочные баллы.
        /// </summary>
        /// <param name="items">Список товаров за которые начисляется скидка.</param>
        public void Update(List<Item> items)
        {
            var totalCost = 0.0;
            foreach (var item in items)
            {
                totalCost += item.Cost;
            }
            AccumulatedPoints += (int)(totalCost * 0.1);
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PointsDiscount"/>.
        /// </summary>
        public PointsDiscount()
        {

        }
    }
}
