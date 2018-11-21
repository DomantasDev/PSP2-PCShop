using Domain.Contracts;
using Models.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Implementation
{
    public class DeliveryService : IDeliveryService
    {
        private const int daysToDeliver = 10;
        public void EstimateDelivery(OrderModel order)
        {
            order.EstimatedDelivery = DateTime.Now.AddDays(Math.Max(3, daysToDeliver - order.Quantity - (int)Math.Round(order.Price / 1000)));
        }
    }
}
