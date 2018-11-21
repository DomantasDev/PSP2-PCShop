using System;

namespace Facade.Contracts
{
    public interface IOrderFacade
    {
        bool TryCreateOrder(Guid pcId, int quantity, Guid clientId, out Guid orderId);
    }
}
