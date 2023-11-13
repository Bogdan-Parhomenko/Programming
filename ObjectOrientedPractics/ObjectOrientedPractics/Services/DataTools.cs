using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    public delegate bool CompareWithValue(Item a, int b);

    public static class DataTools
    {
        public static bool CompareWithCost(Item item, int minCost)
        {
            return item.Cost >= minCost;
        }

        public static bool CompareWithCategory(Item item, int category)
        {
            return item.Category == (Category)category;
        }

        public static BindingList<Item> SortItems(BindingList<Item> items, int value, CompareWithValue compare)
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
    }
}
