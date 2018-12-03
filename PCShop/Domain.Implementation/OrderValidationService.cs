using Domain.Contracts;
using Models.Contracts;
using Models.Contracts.ClientOrder;
using Models.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Implementation
{
    public class OrderValidationService : IOrderValidationService
    {
        public bool ValidateOrder(Order order)
        {
            if (order.Price > order.Client.CashBalance)
                return false;
            return true;
        }
    }
}
