using Models.Contracts;
using Models.Contracts.ClientOrder;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Implementation
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(PcContext ctx) : base(ctx)
        {
            
        }

        public void SubtractMoney(Guid clientId, decimal amount)
        {
            var client = _ctx.Clients.FirstOrDefault(c => c.Id == clientId);
            if (client != null)
            {
                client.CashBalance -= amount;
                _ctx.SaveChanges();
            }
        }
    }
}
