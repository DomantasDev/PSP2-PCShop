using Models.Implementation;
using System;
using System.Collections.Generic;

namespace Facade.Contracts
{
    public interface IOrderFacade
    {
        bool TryCreateOrder(Guid pcId, int quantity, Guid clientId, string destionationCountry, out Guid orderId);
        IEnumerable<OrderModel> GetOrders();
        OrderModel GetOrder(Guid id);
        void Delete(Guid id);
    }
}
