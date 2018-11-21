using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facade.Contracts;
using Microsoft.AspNetCore.Mvc;
using Models.Implementation;
using PCShop.DTO;

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
        public IActionResult CreateOrder([FromBody]OrderDto dto)
        {
            if (_orderFacade.TryCreateOrder(dto.PcId, dto.Quantity, dto.ClientId, dto.DestinationCountry, out var orderId))
                return Ok(orderId);
            return BadRequest();
        }

        [HttpGet]
        public OrderModel Get(Guid id)
        {
            return _orderFacade.GetOrder(id);
        }

        [HttpGet]
        public IEnumerable<OrderModel> Get()
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
