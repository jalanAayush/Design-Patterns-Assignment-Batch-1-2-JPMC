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
            comp = new Computer("Laptop");
        }

        public override void Processor()
        {
            comp["processor"] = "i5";
        }

        public override void Screen()
        {
            comp["screen"] = "16inch";
        }
        public override void HardDisk()
        {
            comp["hardDisk"] = "512GB";
        }

        public override void MotherBoard()
        {
            comp["motherboard"] = "G40";
        }

    }
}
