using Models.Contracts;
using Models.Contracts.ClientOrder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Implementation.VIP
{
    public class VIPClient : Client
    {
        public override void AddCash(decimal cash)
        {
            CashBalance += cash * 1.05m;
        }
    }
}
