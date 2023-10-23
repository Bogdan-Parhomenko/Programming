using ObjectOrientedPractics.Model;
using System;

namespace ObjectOrientedPractics.Services
{
    public static class CustomerFactory
    {
        public static Customer Randomize()
        {
            Random random = new Random();
            var address = new Address(
                random.Next(100000, 1000000),
                random.Next(101).ToString(),
                random.Next(101).ToString(),
                random.Next(101).ToString(),
                random.Next(101).ToString(),
                random.Next(101).ToString()
                );
            var customer = new Customer(
                random.Next(101).ToString(),
                address
                );
            return customer;
        }
    }
}
