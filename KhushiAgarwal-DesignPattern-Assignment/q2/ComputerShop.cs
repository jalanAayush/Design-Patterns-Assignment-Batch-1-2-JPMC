using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    internal class ComputerShop
    {
        public Computer ConstructComputer(IComputerBuilder computer)
        {
            computer.BuildHardDisk();
            computer.BuildMotherboard();
            computer.BuildProcessor();
            computer.BuildScreen();
            computer.displayConfig();
            return computer.build();

        }
    }
}
