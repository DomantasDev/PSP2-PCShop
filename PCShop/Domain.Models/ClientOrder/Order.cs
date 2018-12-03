using System;
using System.Collections.Generic;
using System.Text;
using Models.Contracts.Pcs;

namespace Models.Contracts.ClientOrder
{
    public abstract class Order
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public Guid PcId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string DestinationCountry { get; set; }
        public DateTime EstimatedDelivery { get; set; }

        public string Type { get; set; }

        public Client Client { get; set; }
        public Pc Pc { get; set; }

        public abstract void GetDiscount();
    }
}
