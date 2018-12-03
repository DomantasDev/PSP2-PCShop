using Facade.Contracts.DTOs;
using Facade.Contracts.Requests;
using System;
using System.Collections.Generic;

namespace Facade.Contracts
{
    public interface IOrderFacade
    {
        Guid CreateOrder(OrderRequest request);
        IEnumerable<OrderDto> GetOrders();
        OrderDto GetOrder(Guid id);
        void Delete(Guid id);
    }
}
