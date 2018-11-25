using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facade.Contracts.DTOs
{
    public class ClientDto
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public decimal CashBalance { get; set; }
    }
}
