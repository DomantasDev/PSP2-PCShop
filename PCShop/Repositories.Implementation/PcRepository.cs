using Models.Contracts;
using Models.Contracts.Pcs;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Implementation
{
    public class PcRepository : GenericRepository<Pc>, IPcRepository
    {
        public PcRepository(PcContext ctx) : base(ctx)
        {
        }
    }
}
