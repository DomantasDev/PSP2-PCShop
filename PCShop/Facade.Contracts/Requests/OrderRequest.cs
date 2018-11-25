using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facade.Contracts.Requests
{
    public class OrderRequest
    {
        public Guid ClientId { get; set; }
        public Guid PcId { get; set; }
        public int Quantity { get; set; }
        public string DestinationCountry { get; set; }
    }
}
