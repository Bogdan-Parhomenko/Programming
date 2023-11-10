using ObjectOrientedPractics.Model.Enums;
using System;
using System.ComponentModel;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Хранит данные о процентной скидке.
    /// </summary>
    public class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        /// <summary>
        /// Количество накопленных процентов.
        /// </summary>
        private int _accumulatedPercents;

        /// <summary>
        /// Категория товаров, на которые начислена скидка.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Сумма, на которую покупатель уже сделал покупки определенной категории.
        /// </summary>
        public double TotalAmount { get; set; }

        /// <summary>
        /// Возвращает и задает количество накопленных процентов. Не может быть меньше 1 и больше 10 процентов.
        /// </summary>
        public int AccumulatedPercents
        {
            get => _accumulatedPercents;
            private set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentException("Количество накопленных процентов не божеть быть отрицательным или больше 10.");
                }
                _accumulatedPercents = value;
            }
        }

        /// <summary>
        /// Возвращает строку информации о процентной скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return ($"Процентная «{Category}» - {AccumulatedPercents}%");
            }
        }

        /// <summary>
        /// Расчитывает размер скидки для товаров.
        /// </summary>
        /// <param name="items">Список товаров, которые подлежат скидке.</param>
        /// <returns>Возвращает размер скидки.</returns>
        public double Calculate(BindingList<Item> items)
        {
            var totalCost = 0.0;
            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    totalCost += item.Cost;
                }
            }
            return totalCost * AccumulatedPercents / 100.0;
        }

        /// <summary>
        /// Применяет скидку к товарам.
        /// </summary>
        /// <param name="items">Список товаров, которые подлежат скидке.</param>
        /// <returns>Возвращает размер скидки.</returns>
        public double Apply(BindingList<Item> items)
        {
            return Calculate(items);
        }

        /// <summary>
        /// Добавляет скидочные проценты.
        /// </summary>
        /// <param name="items">Список товаров за которые начисляется скидка.</param>
        public void Update(BindingList<Item> items)
        {
            var totalCost = 0.0;
            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    totalCost += item.Cost;
                }
            }
            if (totalCost >= 1000)
            {
                AccumulatedPercents += 1;
            }
            TotalAmount += totalCost;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PercentDiscount"/>.
        /// </summary>
        public PercentDiscount()
        {
            AccumulatedPercents = 1;
        }

        /// <inheritdoc/>
        public int CompareTo(PercentDiscount other)
        {
            if (AccumulatedPercents == other.AccumulatedPercents)
            {
                return 0;
            }
            else if (AccumulatedPercents < other.AccumulatedPercents)
            {
                return -1;
            }
            else if (AccumulatedPercents > other.AccumulatedPercents)
            {
                return 1;
            }
            return 1;
        }
    }
}
