using Models.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Contracts
{
    public interface IPcFacade
    {
        IEnumerable<PcModel> GetPcs();
        Guid CreatePc(string name, string CPU, string GPU, decimal price);
    }
}
