using Domain.Contracts;
using Models.Contracts;
using Models.Implementation;
using System;

namespace Domain.Implementation
{
    public class DiscountService : IDiscountService
    {
        public void GetDiscount(Order order)
        {
            if (order.Price > 1000)
                order.Price *= 0.9m;
        }
    }
}
