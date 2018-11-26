using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Implementation
{
    public class BasicOrder : Order
    {
        public override void GetDiscount()
        {
            if (Price > 1000)
                Price *= 0.9m;
        }
    }
}
