using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Implementation
{
    public class BasicClient : Client
    {
        public override void AddCash(decimal cash)
        {
            this.CashBalance += cash;
        }
    }
}
