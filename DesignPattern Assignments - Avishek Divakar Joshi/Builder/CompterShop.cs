using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class CompterShop
    {
        public void ConstructComputer(ComputerBuilder builder)
        {
            builder.BuildHardDisk();
            builder.BuildMotherBoard();
            builder.BuildProcessor();
            builder.BuildScreen();
        }
    }
}
