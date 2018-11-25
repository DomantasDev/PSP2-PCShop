using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Contracts
{
    public interface IOrderFactory
    {
        Order CreateOrder(Client client, Pc pc, int quantity, string destinationCountry);
    }
}
