using Models.Contracts;
using Models.Contracts.Pcs;
using Models.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Implementation.Windows
{
    public class WindowsPcFactory : IPcFactory
    {
        public Pc CreatePc(string CPU, string GPU, string name, decimal price )
        {
            return new WindowsPc { CPU = CPU, GPU = GPU, Name = name, Price = price };
        }
    }
}
