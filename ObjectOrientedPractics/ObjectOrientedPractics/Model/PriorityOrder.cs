using System;
using System.ComponentModel;

namespace ObjectOrientedPractics.Model
{
    public class PriorityOrder : Order
    {
        public DateTime DesiredDeliveryDate { get; set; }

        public string  DesiredDeliveryTime { get; set; }

        public PriorityOrder(Address address, BindingList<Item> items) : base(address, items)
        {

        }

        public PriorityOrder(Address address, BindingList<Item> items, DateTime desiredDeliveryDate, string desiredDeliveryTime) : base(address, items)
        {
            DesiredDeliveryDate = desiredDeliveryDate;
            DesiredDeliveryTime = desiredDeliveryTime;
        }
    }
}
