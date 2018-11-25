using Models.Contracts;
using Models.Implementation;
using System;

namespace Domain.Contracts
{
    public interface IDiscountService
    {
        void GetDiscount(Order order);
    }
}
