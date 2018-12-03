using Models.Contracts.ClientOrder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Contracts.Pcs
{
    public abstract class Pc
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public decimal Price { get; set; }
        public string OS { get; set; }

        public string Type { get; set; }

        public IEnumerable<Order> Orders { get; set; }

        public abstract void InstallOS();
    }
}
