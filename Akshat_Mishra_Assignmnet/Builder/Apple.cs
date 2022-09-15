using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{

    class Apple : ComputerBuilder
    {
        public Apple()
        {
            computer = new Computer("Apple");
        }

        public override void HardDisk()
        {
            computer["harddisk"] = "Apple Product Parts";
        }

        public override void MotherBoard()
        {
            computer["motherboard"] = "G41";
        }

        public override void Processor()
        {
            computer["processor"] = "i7 8th gen";
        }

        public override void Screen()
        {
            computer["screen"] = "14inch";
        }
    }
}
