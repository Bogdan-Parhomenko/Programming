using ObjectOrientedPractics.Model;
using System;
using System.ComponentModel;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сервисный класс, предоставляющий доступ к методам фильтрации.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Сравнение двух  для сортировки по возрастанию.
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <returns></returns>
        public static bool CompareAscendingCost(Item x1, Item x2)
        {
            return x1.Cost < x2.Cost;
        }
        // Сравнение двух чисел для сортировки по убыванию
        public static bool CompareDescendingCost(Item x1, Item x2)
        {
            return x1.Cost > x2.Cost;
        }

        public static bool CompareName(Item x1, Item x2)
        {
            if (x1.Name.CompareTo(x2.Name) == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Сравнивает значения и создавет новый список, с удовлетворяющими элементами.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="value">Значение, с которым сравнивается значение товара.</param>
        /// <param name="compare">Метод сравнения.</param>
        /// <returns>Новый список с удовлетворяющими элементами.</returns>
        public static BindingList<Item> ItemsFiltering(BindingList<Item> items, string value, Func<Item, string, bool> compare)
        {
            var newItems = new BindingList<Item>();
            for (int i = 0; i < items.Count; i++)
            {
                if (compare(items[i], value))
                {
                    newItems.Add(items[i]);
                }
            }
            return newItems;
        }

        public static BindingList<Item> SortItems(BindingList<Item> items, Func<Item, Item, bool> compare)
        {
            var newItems = new BindingList<Item>();
            var length = items.Count;
            for (int i = 0; i < length; i++)
            {
                newItems.Add(items[i]);
            }
            for (int i = 0; i < length; i++)
            {
                for (int j = 1; j < length; j++)
                {
                    if (compare(newItems[j], newItems[j - 1]))
                    {
                        var tempVar = newItems[j];
                        newItems[j] = newItems[j - 1];
                        newItems[j - 1] = tempVar;
                    }
                }
                    
            }
            return newItems;
        }
    }
}
