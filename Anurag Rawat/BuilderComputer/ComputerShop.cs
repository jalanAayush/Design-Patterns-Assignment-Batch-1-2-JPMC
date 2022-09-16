using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderComputer
{
    internal class ComputerShop
    {
        public void construct(ComputerBuilder cb)
        {
            cb.BuildHardDisk();
            cb.BuildMotherBoard();
            cb.BuildScreen();
            cb.BuildProcessor();
        }
    }
}
