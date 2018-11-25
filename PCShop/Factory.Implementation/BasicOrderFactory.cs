using Factory.Contracts;
using Models.Contracts;
using Models.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Implementation
{
    public class BasicOrderFactory : IOrderFactory
    {
        public Order CreateOrder(Client client, Pc pc, int quantity, string destinationCountry)
        {
            return new BasicOrder { Client = client, Pc = pc, Quantity = quantity, DestinationCountry = destinationCountry };
        }
    }
}
