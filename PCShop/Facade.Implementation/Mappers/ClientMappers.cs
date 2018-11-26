using Facade.Contracts.DTOs;
using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.Implementation.Mappers
{
    public static class ClientMappers
    {
        public static ClientDto ToDto(this Client client)
        {
            return new ClientDto
            {
                Address = client.Address,
                Email = client.Email,
                CashBalance = client.CashBalance,
                Id = client.Id,
                PhoneNumber = client.PhoneNumber
            };
        }

        public static IEnumerable<ClientDto> ToDtos(this IEnumerable<Client> clients)
        {
            return clients.Select(c => c.ToDto());
        }
    }
}
