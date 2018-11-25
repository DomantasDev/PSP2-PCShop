using Domain.Contracts;
using Models.Contracts;
using Models.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Implementation
{
    public class OrderValidationService : IOrderValidationService
    {
        private readonly IDiscountService _discountService;

        public OrderValidationService(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public bool ValidateOrder(Order order)
        {
            if (order.Price > order.Client.CashBalance)
                return false;
            return true;
        }
    }
}
