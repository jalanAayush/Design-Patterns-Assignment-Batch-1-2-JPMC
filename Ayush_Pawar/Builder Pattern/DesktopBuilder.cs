using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    internal class DesktopBuilder:ComputerBuilder
    {
        public DesktopBuilder()
        {
            this.computer = new Computer("Desktop");
        }

        public override void BuildHardDisk()
        {
            this.computer["HardDisk"] = "1 TB HDD";
        }

        public override void BuildScreen()
        {
            this.computer["Screen"] = "24 inches";
        }

        public override void BuildProcessor()
        {
            this.computer["Processor"] = "intel i5 8th gen";

        }
        public override void BuildMotherBoard()
        {
            this.computer["MotherBoard"] = "DDR 3";

        }
    }
}
