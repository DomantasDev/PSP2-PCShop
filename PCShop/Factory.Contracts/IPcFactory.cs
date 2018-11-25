using Models.Contracts;
using System;

namespace Factory.Contracts
{
    public interface IPcFactory
    {
        Pc CreatePc(string CPU, string GPU, string name, decimal price);
    }
}
