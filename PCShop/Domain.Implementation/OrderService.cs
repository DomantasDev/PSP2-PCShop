using Domain.Contracts;
using DomainServices;
using Models.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IDiscountService _discountService;

        public OrderService(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public bool TryCreateOrder(PcModel pc, int quantity, ClientModel client, out OrderModel order)
        {
            order = new OrderModel(pc, quantity, client);
            _discountService.GetDiscount(order);

            if (order.Price > client.CashBalance)
                return false;
            return true;
        }
    }
}
