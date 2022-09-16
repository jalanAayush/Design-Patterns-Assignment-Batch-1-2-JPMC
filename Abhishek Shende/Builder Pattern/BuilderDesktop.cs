using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class BuilderDesktop:BuilderComputer
    {
        public BuilderDesktop()
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
