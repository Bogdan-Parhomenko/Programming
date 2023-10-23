using ObjectOrientedPractics.Model;
using System;

namespace ObjectOrientedPractics.Services
{
    public static class CustomerFactory
    {
        public static Customer Randomize()
        {
            Random random = new Random();
            var customer = new Customer(
                random.Next(101).ToString(),
                random.Next(101).ToString()
                );
            return customer;
        }
    }
}
