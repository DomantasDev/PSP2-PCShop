using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facade.Contracts;
using Facade.Contracts.DTOs;
using Facade.Contracts.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Contracts;
using Models.Implementation;

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
        public IEnumerable<ClientDto> Get()
        {
            return _clientFacade.GetClients();
        }

        [HttpPost]
        public Guid CreateClient([FromBody]ClientRequest request)
        {
            return _clientFacade.CreateCLient(request);
        }
    }
}