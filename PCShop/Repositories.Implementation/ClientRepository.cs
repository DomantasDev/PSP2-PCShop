using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Implementation
{
    public class ClientRepository : GenericRepository<Client>
    {
        public ClientRepository(PcContext ctx) : base(ctx)
        {
        }
    }
}
