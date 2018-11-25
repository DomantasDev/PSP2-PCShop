using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Contracts
{
    public interface IClientFactory
    {
        Client CreateClient(string email, string address, decimal cashBalance);
    }
}
