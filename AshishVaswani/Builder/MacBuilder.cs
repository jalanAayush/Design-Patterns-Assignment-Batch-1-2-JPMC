using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    internal class MacBuilder : ComputerBuilder
    {
        public MacBuilder()
        {
            this.computer = new Computer("Mac");
        }

        public override void BuildHardDisk()
        {
            this.computer["HardDisk"] = "1 TB SSD";
        }

        public override void BuildScreen()
        {
            this.computer["Screen"] = "16 inches";
        }

        public override void BuildProcessor()
        {
            this.computer["Processor"] = "i7";

        }
        public override void BuildMotherBoard()
        {
            this.computer["MotherBoard"] = "2.7GHz";

        }
    }
}
