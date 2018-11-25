using Facade.Contracts;
using Facade.Contracts.DTOs;
using Facade.Contracts.Requests;
using Facade.Implementation.Mappers;
using Factory.Contracts;
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

        public ClientFacade(IClientRepository clientRepo, IClientFactory clientFacotry)
        {
            _clientRepo = clientRepo;
            _clientFacotry = clientFacotry;
        }

        public IEnumerable<ClientDto> GetClients()
        {
            return _clientRepo.Get().ToDtos();
        }

        public Guid CreateCLient(ClientRequest request)
        {
            return _clientRepo.Save(_clientFacotry.CreateClient(request.Email, request.Address, request.CashBalance)).Id;
        }
    }
}
