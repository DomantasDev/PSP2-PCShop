using Models.Contracts;
using System;

namespace Models.Contracts.Pcs
{
    public interface IPcFactory
    {
        Pc CreatePc(string CPU, string GPU, string name, decimal price);
    }
}
