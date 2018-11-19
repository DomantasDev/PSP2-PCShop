using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Contracts
{
    public interface IModel
    {
        Guid Id { get; set; }
    }
}
