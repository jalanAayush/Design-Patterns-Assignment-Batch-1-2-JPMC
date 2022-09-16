using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderComputer
{
    internal class DesktopBuilder : ComputerBuilder
    {
        public DesktopBuilder()
        {
            computer = new Computer("Desktop");
        }

        public override void BuildHardDisk()
        {
            computer["HardDisk"] = "Desktop HardDisk";
        }

        public override void BuildMotherBoard()
        {
            computer["MotherBoard"] = "Desktop MotherBoard";
        }
        public override void BuildProcessor()
        {
            computer["Processor"] = "Desktop Processor";
        }
        public override void BuildScreen()
        {
            computer["Screen"] = "Desktop Screen";
        }
    }
}
