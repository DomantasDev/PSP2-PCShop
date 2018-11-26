using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facade.Contracts.Requests
{
    public class ClientRequest
    {
        public string Email { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public decimal CashBalance { get; set; }
    }
}
