using Models.Contracts;
using Models.Contracts.ClientOrder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Implementation.VIP
{
    public class VIPOrder : Order
    {
        public override void GetDiscount()
        {
            if (Price > 900)
                Price *= 0.8m;
        }
    }
}
