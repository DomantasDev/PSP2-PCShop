using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Contracts
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
