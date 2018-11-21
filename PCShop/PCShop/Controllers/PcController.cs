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
    public class PcController : ControllerBase
    {
        private readonly IPcFacade _pcFacade;

        public PcController(IPcFacade pcFacade)
        {
            _pcFacade = pcFacade;
        }

        [HttpGet]
        public IEnumerable<PcModel> Get()
        {
            return _pcFacade.GetPcs();
        }

        [HttpPost]
        public Guid CreatePc([FromBody]PcDto dto)
        {
            return _pcFacade.CreatePc(dto.Name, dto.CPU, dto.GPU, dto.Price);
        }
    }
}
