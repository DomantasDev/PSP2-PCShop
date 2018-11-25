using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Implementation
{
    public class VIPOrder : Order
    {
        public override void GetDiscount()
        {
            throw new NotImplementedException();
        }
    }
}
