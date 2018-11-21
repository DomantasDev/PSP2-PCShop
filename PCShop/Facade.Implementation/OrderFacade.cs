using Domain.Contracts;
using Facade.Contracts;
using Models.Implementation;
using Repositories.Contracts;
using System;

namespace Facade.Implementation
{
    public class OrderFacade : IOrderFacade
    {
        private readonly IOrderService _orderService;
        private readonly IRepository<ClientModel> _clientRepo;
        private readonly IRepository<PcModel> _pcRepo;
        private readonly IRepository<OrderModel> _ordersRepo;

        public OrderFacade(IOrderService orderService, IRepository<OrderModel> ordersRepo, IRepository<PcModel> pcRepo, IRepository<ClientModel> clientRepo)
        {
            _orderService = orderService;
            _clientRepo  = clientRepo;
            _pcRepo = pcRepo;
            _ordersRepo = ordersRepo;
        }

        public bool TryCreateOrder(Guid pcId, int quantity, Guid clientId, out Guid orderId)
        {
            var pc = _pcRepo.Get(pcId);
            var client = _clientRepo.Get(clientId);
            if(_orderService.TryCreateOrder(pc, quantity, client, out var order))
            {
                orderId = _ordersRepo.Save(order);
                return true;
            }
            orderId = new Guid();
            return false;
        }
    }
}
