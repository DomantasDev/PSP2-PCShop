using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Facade.Contracts;
using Facade.Contracts.DTOs;
using Facade.Contracts.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Implementation;

namespace PCShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PcController : ControllerBase
    {
        private readonly IPcFacade _pcFacade;

        public PcController(IPcFacade pcFacade)
        {
            _pcFacade = pcFacade;
        }

        [HttpGet]
        public IEnumerable<PcDto> Get()
        {
            return _pcFacade.GetPcs();
        }

        [HttpPost]
        public Guid CreatePc([FromBody]PcRequest request)
        {
            return _pcFacade.CreatePc(request);
        }
    }
}
