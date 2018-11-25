using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facade.Contracts;
using Facade.Contracts.DTOs;
using Facade.Contracts.Requests;
using Microsoft.AspNetCore.Mvc;
using Models.Implementation;

namespace PCShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : Controller
    {
        private readonly IOrderFacade _orderFacade;

        public OrdersController(IOrderFacade orderFacade)
        {
            _orderFacade = orderFacade;
        }

        [HttpPost("CreateOrder")]
        public Guid CreateOrder([FromBody]OrderRequest request)
        {
            return _orderFacade.CreateOrder(request);
        }

        [HttpGet]
        public OrderDto Get(Guid id)
        {
            return _orderFacade.GetOrder(id);
        }

        [HttpGet]
        public IEnumerable<OrderDto> Get()
        {
            return _orderFacade.GetOrders();
        }

        [HttpDelete]
        public void Delete(Guid id)
        {
            _orderFacade.Delete(id);
        }
    }
}
