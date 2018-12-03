using Models.Contracts.Pcs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Contracts.ClientOrder
{
    public interface IClientOrderFactory
    {
        Client CreateClient(string email, string address, decimal cashBalance, int phoneNumber);
        Order CreateOrder(Client client, Pc pc, int quantity, string destinationCountry);
    }
}
