using Facade.Contracts;
using Facade.Contracts.DTOs;
using Facade.Contracts.Requests;
using Facade.Implementation.Mappers;
using Factory.Contracts;
using Models.Contracts;
using Models.Implementation;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.Implementation
{
    public class PcFacade : IPcFacade
    {
        private readonly IPcRepository _pcRepo;
        private readonly IPcFactory _pcFactory;

        public PcFacade(IPcRepository pcRepo, IPcFactory pcFactory)
        {
            _pcRepo = pcRepo;
            _pcFactory = pcFactory;
        }

        public IEnumerable<PcDto> GetPcs()
        {
            return _pcRepo.Get().ToDtos();
        }

        public Guid CreatePc(PcRequest request)
        {
            var pc = _pcFactory.CreatePc(request.CPU, request.GPU, request.Name, request.Price);
            pc.InstallOS();
            return _pcRepo.Save(pc).Id;
        }
    }
}
