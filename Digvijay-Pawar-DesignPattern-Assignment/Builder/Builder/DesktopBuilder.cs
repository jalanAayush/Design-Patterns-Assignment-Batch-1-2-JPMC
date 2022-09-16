using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class DesktopBuilder : ComputerBuilder
    {
        public DesktopBuilder()
        {
            comp = new Computer("Desktop");
        }
        public override void Processor()
        {
            comp["processor"] = "i7";
        }

        public override void Screen()
        {
            comp["screen"] = "28inch";
        }

        public override void HardDisk()
        {
            comp["hardDisk"] = "256GB";
        }

        public override void MotherBoard()
        {
            comp["motherboard"] = "G41";
        }

    }
}
