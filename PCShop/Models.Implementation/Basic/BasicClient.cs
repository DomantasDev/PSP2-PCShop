using Models.Contracts;
using Models.Contracts.ClientOrder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Implementation.Basic
{
    public class BasicClient : Client
    {
        public override void AddCash(decimal cash)
        {
            CashBalance += cash;
        }
    }
}
