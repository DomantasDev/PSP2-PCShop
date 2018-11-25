using Factory.Contracts;
using Models.Contracts;
using Models.Implementation;
using System;

namespace Factory.Implementation
{
    public class BasicClientFactory : IClientFactory
    {
        public Client CreateClient(string email, string address, decimal cashBalance)
        {
            return new BasicClient { Address = address, CashBalance = cashBalance, Email = email };
        }
    }
}
