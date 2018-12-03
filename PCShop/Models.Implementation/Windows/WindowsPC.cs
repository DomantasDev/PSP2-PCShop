using Models.Contracts;
using Models.Contracts.Pcs;
using System;
using System.Collections.Generic;

namespace Models.Implementation.Windows
{
    public class WindowsPc : Pc
    {
        public override void InstallOS()
        {
            OS = "Windows";
        }
    }
}
