using Domain.Contracts;
using Models.Contracts;
using Models.Contracts.ClientOrder;
using Models.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Implementation
{
    public class TaxService : ITaxService
    {
        public void CalculateTaxes(Order order)
        {
            if (order.DestinationCountry != "Lietuva")
                order.Price *= 1.2m;
        }
    }
}
