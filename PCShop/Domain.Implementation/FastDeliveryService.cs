using Domain.Contracts;
using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Implementation
{
    public class FastDeliveryService : IDeliveryService
    {
        public void EstimateDelivery(Order order)
        {
            order.EstimatedDelivery = DateTime.Now.AddDays(Math.Max(3, 9 - order.Quantity - (int)Math.Round(order.Price / 900)));
        }
    }
}
