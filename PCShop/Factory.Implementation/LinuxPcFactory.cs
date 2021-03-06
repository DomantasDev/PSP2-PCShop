﻿using Models.Contracts;
using Models.Contracts.Pcs;
using Models.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Implementation
{
    public class LinuxPcFactory : IPcFactory
    {
        public Pc CreatePc(string CPU, string GPU, string name, decimal price)
        {
            return new LinuxPc { CPU = CPU, GPU = GPU, Name = name, Price = price };
        }
    }
}
