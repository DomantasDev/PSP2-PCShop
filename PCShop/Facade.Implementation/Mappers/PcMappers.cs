using Facade.Contracts.DTOs;
using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade.Implementation.Mappers
{
    public static class PcMappers
    {
        public static PcDto ToDto(this Pc pc)
        {
            return new PcDto
            {
                CPU = pc.CPU,
                GPU = pc.GPU,
                Name = pc.Name,
                Price = pc.Price,
                Id = pc.Id
            };
        }


        public static IEnumerable<PcDto> ToDtos(this IEnumerable<Pc> pcs)
        {
            return pcs.Select(c => c.ToDto());
        }
    }
}
