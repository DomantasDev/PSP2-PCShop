using Models.Implementation;
using System;

namespace DomainServices
{
    public interface IDiscountService
    {
        void GetDiscount(OrderModel order);
    }
}
