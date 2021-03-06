﻿using Models.Contracts;
using Models.Contracts.ClientOrder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Contracts
{
    public interface IClientRepository : IRepository<Client>
    {
        void SubtractMoney(Guid clientId, decimal amount);
    }
}
