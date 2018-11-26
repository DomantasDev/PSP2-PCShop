using Domain.Contracts;
using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Implementation
{
    public class LoanOrderValidationService : IOrderValidationService
    {
        public bool ValidateOrder(Order order)
        {
            if (order.Price - order.Client.CashBalance > -500 )
                return false;
            return true;
        }
    }
}
