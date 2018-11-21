using Models.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contracts
{
    public interface IOrderService
    {
        bool TryCreateOrder(PcModel pc, int quantity, ClientModel client, out OrderModel order);
    }
}
