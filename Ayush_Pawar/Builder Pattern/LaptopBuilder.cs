using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    internal class LaptopBuilder:ComputerBuilder
    {
        public LaptopBuilder()
        {
            this.computer = new Computer("Laptop");
        }

        public override void  BuildHardDisk()
        {
            this.computer["HardDisk"] = "1 TB HDD";
        }

        public override void BuildScreen()
        {
            this.computer["Screen"] = "27 inches";
        }

        public override void BuildProcessor()
        {
            this.computer["Processor"] = "intel i7 10th gen";
        }
        public override void BuildMotherBoard()
        {
            this.computer["MotherBoard"] = "DDR 4";
        }
    }
}
