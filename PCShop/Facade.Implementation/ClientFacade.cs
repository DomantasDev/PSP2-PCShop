using Facade.Contracts;
using Models.Implementation;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Implementation
{
    public class ClientFacade : IClientFacade
    {
        private readonly IRepository<ClientModel> _clientRepo;

        public ClientFacade(IRepository<ClientModel> clientRepo)
        {
            _clientRepo = clientRepo;
        }

        public IEnumerable<ClientModel> GetClients()
        {
            return _clientRepo.Get();
        }

        public Guid CreateCLient(string email, string address, decimal cashBalance)
        {
            return _clientRepo.Save(new ClientModel { Email = email, Address = address, CashBalance = cashBalance});
        }
    }
}
