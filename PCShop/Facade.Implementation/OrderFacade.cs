using Domain.Contracts;
using Facade.Contracts;
using Models.Implementation;
using Repositories.Contracts;
using System;
using System.Linq;
using System.Collections.Generic;
using Facade.Contracts.Requests;
using Models.Contracts;
using Factory.Contracts;
using Facade.Contracts.DTOs;
using Facade.Implementation.Mappers;

namespace Facade.Implementation
{
    public class OrderFacade : IOrderFacade
    {
        private readonly IOrderValidationService _orderValidationService;
        private readonly IClientRepository _clientRepo;
        private readonly IPcRepository _pcRepo;
        private readonly IOrderRepository _ordersRepo;
        private readonly IDiscountService _discountService;
        private readonly IDeliveryService _deliveryService;
        private readonly ITaxService _taxService;
        private readonly IOrderFactory _orderFactory;

        public OrderFacade(IOrderValidationService orderValidationService, IOrderRepository ordersRepo, IPcRepository pcRepo, IClientRepository clientRepo, IDiscountService discountService, IDeliveryService deliveryService, ITaxService taxService, IOrderFactory orderFactory)
        {
            _orderValidationService = orderValidationService;
            _clientRepo  = clientRepo;
            _pcRepo = pcRepo;
            _ordersRepo = ordersRepo;
            _discountService = discountService;
            _deliveryService = deliveryService;
            _taxService = taxService;
            _orderFactory = orderFactory;
        }

        public Guid CreateOrder(OrderRequest request)
        {
            var pc = _pcRepo.Get(request.PcId);
            var client = _clientRepo.Get(request.ClientId);

            var order = _orderFactory.CreateOrder(client, pc, request.Quantity, request.DestinationCountry);

            _discountService.GetDiscount(order);
            _taxService.CalculateTaxes(order);

            if (!_orderValidationService.ValidateOrder(order))
                throw new ArgumentException();

            _deliveryService.EstimateDelivery(order);
            return _ordersRepo.Save(order).Id;
        }

        public IEnumerable<OrderDto> GetOrders()
        {
            return _ordersRepo.Get().ToDtos();
        }

        public OrderDto GetOrder(Guid id)
        {
            return _ordersRepo.Get(id).ToDto();
        }

        public void Delete(Guid id)
        {
            _ordersRepo.Delete(id);
        }
    }
}
