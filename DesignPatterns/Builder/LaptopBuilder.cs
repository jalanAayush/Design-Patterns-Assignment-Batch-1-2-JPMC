using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class LaptopBuilder : ComputerBuilder
    {
        public LaptopBuilder()
        {
            computer = new Computer("Laptop");
        }
        public override void BuildHardDisk()
        {
            computer["hardDisk"] = "Laptop Hard Disk";
        }

        public override void BuildMotherBoard()
        {
            computer["motherBoard"] = "Laptop Mother Board";
        }

        public override void BuildProcessor()
        {
            computer["processor"] = "Laptop Processor";
        }

        public override void BuildScreen()
        {
            computer["screen"] = "Laptop Screen";
        }
    }
}
