using Facade.Contracts.DTOs;
using Facade.Contracts.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Contracts
{
    public interface IClientFacade
    {
        IEnumerable<ClientDto> GetClients();
        Guid CreateCLient(ClientRequest request);
    }
}
