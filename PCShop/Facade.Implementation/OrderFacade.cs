using Domain.Contracts;
using Facade.Contracts;
using Models.Implementation;
using Repositories.Contracts;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Facade.Implementation
{
    public class OrderFacade : IOrderFacade
    {
        private readonly IOrderValidationService _orderValidationService;
        private readonly IRepository<ClientModel> _clientRepo;
        private readonly IRepository<PcModel> _pcRepo;
        private readonly IRepository<OrderModel> _ordersRepo;
        private readonly IDiscountService _discountService;
        private readonly IDeliveryService _deliveryService;
        private readonly ITaxService _taxService;

        public OrderFacade(IOrderValidationService orderValidationService, IRepository<OrderModel> ordersRepo, IRepository<PcModel> pcRepo, IRepository<ClientModel> clientRepo, IDiscountService discountService, IDeliveryService deliveryService, ITaxService taxService)
        {
            _orderValidationService = orderValidationService;
            _clientRepo  = clientRepo;
            _pcRepo = pcRepo;
            _ordersRepo = ordersRepo;
            _discountService = discountService;
            _deliveryService = deliveryService;
            _taxService = taxService;
        }

        public bool TryCreateOrder(Guid pcId, int quantity, Guid clientId, string destinationCountry, out Guid orderId)
        {
            var pc = _pcRepo.Get(pcId);
            var client = _clientRepo.Get(clientId);

            var order = new OrderModel(pc, quantity, client, destinationCountry);

            _discountService.GetDiscount(order);
            _taxService.CalculateTaxes(order);
            if(_orderValidationService.ValidateOrder(order))
            {
                _deliveryService.EstimateDelivery(order);
                orderId = _ordersRepo.Save(order);
                return true;
            }
            
            orderId = new Guid();
            return false;
        }

        public IEnumerable<OrderModel> GetOrders()
        {
            return _ordersRepo.Get();
        }

        public OrderModel GetOrder(Guid id)
        {
            return _ordersRepo.Get(id);
        }

        public void Delete(Guid id)
        {
            _ordersRepo.Delete(id);
        }
    }
}
