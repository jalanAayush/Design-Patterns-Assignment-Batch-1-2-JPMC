using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class AppleBuilder : ComputerBuilder
    {
        public AppleBuilder()
        {
            computer = new Computer("Apple");
        }
        public override void BuildHardDisk()
        {
            computer["hardDisk"] = "Apple Hard Disk";
        }

        public override void BuildMotherBoard()
        {
            computer["motherBoard"] = "Apple Mother Board";
        }

        public override void BuildProcessor()
        {
            computer["processor"] = "Apple Processor";
        }

        public override void BuildScreen()
        {
            computer["screen"] = "Apple Screen";
        }
    }
}
