using Models.Contracts;
using System;
using System.Collections.Generic;

namespace Models.Implementation
{
    public class WindowsPc : Pc
    {
        public override void InstallOS()
        {
            OS = "Windows";
        }
    }
}
