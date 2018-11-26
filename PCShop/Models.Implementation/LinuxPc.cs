using Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Implementation
{
    public class LinuxPc : Pc
    {
        public override void InstallOS()
        {
            OS = "Linux";
        }
    }
}
