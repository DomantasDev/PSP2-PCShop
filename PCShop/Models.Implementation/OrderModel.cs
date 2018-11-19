using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Implementation
{
    public class OrderModel : IModel
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public Guid PcId { get; set; }
        public int Quantity { get; set; }

        public ClientModel Client { get; set; }
        public PcModel Pc { get; set; }
    }
}
