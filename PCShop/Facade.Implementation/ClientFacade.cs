using Facade.Contracts;
using Facade.Contracts.DTOs;
using Facade.Contracts.Requests;
using Facade.Implementation.Mappers;
using Factory.Contracts;
using Integrations.Contracts;
using Models.Implementation;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.Implementation
{
    public class ClientFacade : IClientFacade
    {
        private readonly IClientRepository _clientRepo;
        private readonly IClientFactory _clientFacotry;
        private readonly INotifier _notifier;

        public ClientFacade(IClientRepository clientRepo, IClientFactory clientFacotry, INotifier notifier)
        {
            _clientRepo = clientRepo;
            _clientFacotry = clientFacotry;
            _notifier = notifier;
        }

        public IEnumerable<ClientDto> GetClients()
        {
            return _clientRepo.Get().ToDtos();
        }

        public Guid CreateCLient(ClientRequest request)
        {
            var client = _clientRepo.Save(_clientFacotry.CreateClient(request.Email, request.Address, request.CashBalance, request.PhoneNumber));
            _notifier.Notify(client, "An account has been created for you");
            return client.Id;
        }
    }
}
