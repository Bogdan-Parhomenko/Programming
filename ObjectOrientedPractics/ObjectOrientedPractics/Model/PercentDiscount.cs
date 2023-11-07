using System;
using System.Collections.Generic;
namespace ObjectOrientedPractics.Model
{
    public class PercentDiscount
    {
        private int _accumulatedPercents;

        public Category Category { get; set; }

        public double TotalAmount { get; set; }

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

        public double Calculate(List<Item> items)
        {
            var totalCost = 0.0;
            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    totalCost += item.Cost;
                }
            }
            return totalCost * (AccumulatedPercents / 100);
        }

        public double Apply(List<Item> items)
        {
            var discount = Calculate(items);
            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    item.Cost -= discount / items.Count;
                }
            }
            return (int)discount;
        }

        public void Update(List<Item> items)
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
        }

        public string Info()
        {
            return($"Процентная «{Category}» - {AccumulatedPercents}%");
        }

        public PercentDiscount()
        {
            AccumulatedPercents = 1;
        }
    }
}
