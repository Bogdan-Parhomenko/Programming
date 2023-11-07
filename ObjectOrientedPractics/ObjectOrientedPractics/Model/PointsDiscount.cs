using System;
using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    public class PointsDiscount
    {
        private int _accumulatedPoints;

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

        public void Update(List<Item> items)
        {
            var totalCost = 0.0;
            foreach (var item in items)
            {
                totalCost += item.Cost;
            }
            AccumulatedPoints += (int)(totalCost * 0.1);
        }

        public string Info()
        {
            return $"Накопительная – {AccumulatedPoints} баллов";
        }

        public PointsDiscount()
        {

        }
    }
}
