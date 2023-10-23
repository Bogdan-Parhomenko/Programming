using ObjectOrientedPractics.Model;
using System;

namespace ObjectOrientedPractics.Services
{
    public static class ItemFactory
    {
        public static Item Randomize()
        {
            Random random = new Random();
            var item = new Item(
                random.Next(1, 101).ToString(),
                random.Next(1, 101).ToString(),
                random.Next(1, 100000),
                (Category)Enum.Parse(typeof(Category), random.Next(7).ToString())
                );
            return item;
        }
    }
}
