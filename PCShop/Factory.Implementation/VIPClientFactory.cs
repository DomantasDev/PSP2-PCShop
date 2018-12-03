using Factory.Contracts;
using Models.Contracts;
using Models.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Implementation
{
    public class VIPClientFactory : IClientFactory
    {
        public Client CreateClient(string email, string address, decimal cashBalance, int phoneNumber)
        {
            return new VIPClient { Address = address, CashBalance = cashBalance, Email = email, PhoneNumber = phoneNumber };
        }
    }
}
