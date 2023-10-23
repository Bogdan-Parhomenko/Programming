using ObjectOrientedPractics.Model;
using System;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Служебный класс, который содержит методы генерации случайных товаров.
    /// </summary>
    public static class ItemFactory
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/> и заполняет его случайными значениями.
        /// </summary>
        /// <returns>Экземпляр товара с заполненными полями.</returns>
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
