using Facade.Contracts;
using Models.Implementation;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Implementation
{
    public class PcFacade : IPcFacade
    {
        private readonly IRepository<PcModel> _pcRepo;

        public PcFacade(IRepository<PcModel> pcRepo)
        {
            _pcRepo = pcRepo;
        }

        public IEnumerable<PcModel> GetPcs()
        {
            return _pcRepo.Get();
        }

        public Guid CreatePc(string name, string CPU, string GPU, decimal price)
        {
            return _pcRepo.Save(new PcModel { Name = name, CPU = CPU, GPU = GPU, Price = price });
        }
    }
}
