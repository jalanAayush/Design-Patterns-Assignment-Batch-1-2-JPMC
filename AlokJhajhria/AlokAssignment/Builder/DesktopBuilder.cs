using System;
using System.Collections;
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
            computer = new Computer("Desktop");
        }
        public override void BuildHardDisk()
        {
            computer["hardDisk"] = "Desktop Hard Disk";
        }

        public override void BuildMotherBoard()
        {
            computer["motherBoard"] = "Desktop Mother Board";
        }

        public override void BuildProcessor()
        {
            computer["processor"] = "Desktop Processor";
        }

        public override void BuildScreen()
        {
            computer["screen"] = "Desktop Screen";
        }
    }
}
