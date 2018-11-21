using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facade.Contracts;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult CreateOrder(Guid pcId, int quantity, Guid clientId)
        {
            if (_orderFacade.TryCreateOrder(pcId, quantity, clientId, out var orderId))
                return Ok(orderId);
            return BadRequest();
        }
    }
}
