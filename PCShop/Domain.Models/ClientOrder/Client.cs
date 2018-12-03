using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Contracts.ClientOrder
{
    public abstract class Client
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public decimal CashBalance { get; set; }

        public string Type { get; set; }

        public IEnumerable<Order> Orders { get; set; }

        public abstract void AddCash(decimal cash);
    }
}
