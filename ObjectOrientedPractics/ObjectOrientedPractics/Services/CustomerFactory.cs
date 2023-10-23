using ObjectOrientedPractics.Model;
using System;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Служебный класс, который содержит методы генерации случайных покупателей.
    /// </summary>
    public static class CustomerFactory
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/> и заполняет его случайными значениями.
        /// </summary>
        /// <returns>Экземпляр покупателя с заполненными полями.</returns>
        public static Customer Randomize()
        {
            Random random = new Random();
            var address = new Address(
                random.Next(100000, 1000000),
                random.Next(1, 101).ToString(),
                random.Next(1, 101).ToString(),
                random.Next(1, 101).ToString(),
                random.Next(1, 101).ToString(),
                random.Next(1, 101).ToString()
                );
            var customer = new Customer(
                random.Next(1, 101).ToString(),
                address
                );
            return customer;
        }
    }
}
