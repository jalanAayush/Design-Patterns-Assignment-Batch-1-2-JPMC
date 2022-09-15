using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Laptop : ComputerBuilder
    {
        public Laptop()
        {
            computer = new Computer("Laptop");
        }

        public override void HardDisk()
        {
            Computer["harddisk"] = "Laptop Product Parts";
        }

        public override void MotherBoard()
        {
            Computer["motherboard"] = "G41";
        }

        public override void Processor()
        {
            Computer["processor"] = "i7 8th gen";
        }

        public override void Screen()
        {
            Computer["screen"] = "14inch";
        }
    }
}
