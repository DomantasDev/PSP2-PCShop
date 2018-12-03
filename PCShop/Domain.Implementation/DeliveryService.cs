using Domain.Contracts;
using Models.Contracts;
using Models.Contracts.ClientOrder;
using Models.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Implementation
{
    public class DeliveryService : IDeliveryService
    {
        public void EstimateDelivery(Order order)
        {
            order.EstimatedDelivery = DateTime.Now.AddDays(Math.Max(4, 10 - order.Quantity - (int)Math.Round(order.Price / 1000)));
        }
    }
}
