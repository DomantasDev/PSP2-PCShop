﻿using Models.Contracts;
using Models.Contracts.ClientOrder;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Implementation
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(PcContext ctx) : base(ctx)
        {
        }
    }
}
