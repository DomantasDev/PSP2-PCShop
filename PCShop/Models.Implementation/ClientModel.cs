using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Implementation
{
    public class ClientModel : IModel
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public IEnumerable<OrderModel> Orders { get; set; }
    }
}
