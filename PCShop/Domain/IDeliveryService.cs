using Models.Contracts;
using Models.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contracts
{
    public interface IDeliveryService
    {
        void EstimateDelivery(Order order);
    }
}
