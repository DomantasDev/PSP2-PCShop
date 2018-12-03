using Facade.Contracts.DTOs;
using Facade.Contracts.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Contracts
{
    public interface IPcFacade
    {
        IEnumerable<PcDto> GetPcs();
        Guid CreatePc(PcRequest request);
    }
}
