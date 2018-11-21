using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facade.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Implementation;
using PCShop.DTO;

namespace PCShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        private readonly IClientFacade _clientFacade;

        public ClientController(IClientFacade clientFacade)
        {
            _clientFacade = clientFacade;
        }

        [HttpGet]
        public IEnumerable<ClientModel> Get()
        {
            return _clientFacade.GetClients();
        }

        [HttpPost]
        public Guid CreateClient([FromBody]ClientDto dto)
        {
            return _clientFacade.CreateCLient(dto.Email, dto.Address, dto.CashBalance);
        }
    }
}