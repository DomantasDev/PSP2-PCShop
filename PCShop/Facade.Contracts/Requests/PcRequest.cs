using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facade.Contracts.Requests
{
    public class PcRequest
    {
        public string Name { get; set; }
        public string GPU { get; set; }
        public string CPU { get; set; }
        public decimal Price { get; set; }
    }
}
