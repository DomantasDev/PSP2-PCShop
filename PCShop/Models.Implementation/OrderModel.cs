using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Implementation
{
    public class OrderModel : IModel
    {
        public OrderModel(PcModel pc, int quantity, ClientModel client)
        {
            Pc = pc;
            Client = client;
            Quantity = quantity;
            Price = pc.Price * quantity;
        }

        public OrderModel()
        {

        }

        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public Guid PcId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public ClientModel Client { get; set; }
        public PcModel Pc { get; set; }
    }
}
