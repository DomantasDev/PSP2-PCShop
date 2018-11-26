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
            if (Price > 900)
                Price *= 0.8m;
        }
    }
}
