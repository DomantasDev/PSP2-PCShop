using Models.Contracts;
using Models.Contracts.ClientOrder;
using Models.Contracts.Pcs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Implementation.VIP
{
    public class VIPFactory : IClientOrderFactory
    {
        public Client CreateClient(string email, string address, decimal cashBalance, int phoneNumber)
        {
            return new VIPClient { Address = address, CashBalance = cashBalance, Email = email, PhoneNumber = phoneNumber };
        }

        public Order CreateOrder(Client client, Pc pc, int quantity, string destinationCountry)
        {
            return new VIPOrder { Client = client, Pc = pc, Quantity = quantity, DestinationCountry = destinationCountry, Price = pc.Price * quantity };
        }
    }
}
