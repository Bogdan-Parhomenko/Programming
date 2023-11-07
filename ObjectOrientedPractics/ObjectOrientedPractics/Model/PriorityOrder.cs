using System;

namespace ObjectOrientedPractics.Model
{
    public class PriorityOrder : Order
    {
        public DateTime DesiredDeliveryDate { get; set; }

        public string  DesiredDeliveryTime { get; set; }

        public PriorityOrder()
        {

        }

        public PriorityOrder(DateTime desiredDeliveryDate, string desiredDeliveryTime)
        {
            DesiredDeliveryDate = desiredDeliveryDate;
            DesiredDeliveryTime = desiredDeliveryTime;
        }
    }
}
