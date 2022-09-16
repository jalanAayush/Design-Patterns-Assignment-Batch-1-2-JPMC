using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
     class AppleBuilder :ComputerBuilder
    {
        public AppleBuilder()
        {
            comp = new Computer("Apple");
        }
        public override void Processor()
        {
            comp["processor"] = "i7";
        }

        public override void Screen()
        {
            comp["screen"] = "24inch";
        }
        public override void HardDisk()
        {
            comp["hardDisk"] = "1TB";
        }

        public override void MotherBoard()
        {
            comp["motherboard"] = "G41";
        }

    }
}
