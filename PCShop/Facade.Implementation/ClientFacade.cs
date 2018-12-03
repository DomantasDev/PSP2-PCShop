using Facade.Contracts;
using Facade.Contracts.DTOs;
using Facade.Contracts.Requests;
using Facade.Implementation.Mappers;
using Integrations.Contracts;
using Models.Contracts.ClientOrder;
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
        private readonly IClientOrderFactory _clientOrderFacotry;
        private readonly INotifier _notifier;

        public ClientFacade(IClientRepository clientRepo, IClientOrderFactory clientOrderFactory, INotifier notifier)
        {
            _clientRepo = clientRepo;
            _clientOrderFacotry = clientOrderFactory;
            _notifier = notifier;
        }

        public IEnumerable<ClientDto> GetClients()
        {
            return _clientRepo.Get().ToDtos();
        }

        public Guid CreateCLient(ClientRequest request)
        {
            var client = _clientRepo.Save(_clientOrderFacotry.CreateClient(request.Email, request.Address, request.CashBalance, request.PhoneNumber));
            _notifier.Notify(client, "An account has been created for you");
            return client.Id;
        }
    }
}
