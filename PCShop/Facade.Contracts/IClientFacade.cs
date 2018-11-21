using Models.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Contracts
{
    public interface IClientFacade
    {
        IEnumerable<ClientModel> GetClients();
        Guid CreateCLient(string email, string address, decimal cashBalance);
    }
}
