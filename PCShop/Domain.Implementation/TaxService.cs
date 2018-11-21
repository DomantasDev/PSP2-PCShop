using Models.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Implementation
{
    public class TaxService
    {
        public void CalculateTaxes(OrderModel order)
        {
            if (order.DestinationCountry != "Lietuva")
                order.Price *= 1.2m;
        }
    }
}
