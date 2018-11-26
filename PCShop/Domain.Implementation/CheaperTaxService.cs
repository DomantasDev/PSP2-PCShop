using Domain.Contracts;
using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Implementation
{
    public class CheaperTaxService : ITaxService
    {
        public void CalculateTaxes(Order order)
        {
            if (order.DestinationCountry != "Lietuva")
                order.Price *= 1.1m;
        }
    }
}
