using Models.Contracts;
using System;
using System.Collections.Generic;

namespace Models.Implementation
{
    public class PcModel : IModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CPU { get; set; }
        public string GPU { get; set; }
        public decimal Price { get; set; }

        public IEnumerable<OrderModel> Orders { get; set; }
    }
}
