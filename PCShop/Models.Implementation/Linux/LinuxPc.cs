using Models.Contracts;
using Models.Contracts.Pcs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Implementation.Linux
{
    public class LinuxPc : Pc
    {
        public override void InstallOS()
        {
            OS = "Linux";
        }
    }
}
