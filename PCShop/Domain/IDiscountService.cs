using Models.Implementation;
using System;

namespace Domain.Contracts
{
    public interface IDiscountService
    {
        void GetDiscount(OrderModel order);
    }
}
