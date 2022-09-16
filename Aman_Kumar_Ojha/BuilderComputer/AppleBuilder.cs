using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderComputer
{
    internal class AppleBuilder : ComputerBuilder
    {
         public AppleBuilder()
        {
            computer = new Computer("Apple");
        }

        public override void BuildHardDisk()
        {
            computer["HardDisk"] = "Apple HardDisk";
        }

        public override void BuildMotherBoard()
        {
            computer["MotherBoard"] = "Apple MotherBoard";
        }
        public override void BuildProcessor()
        {
            computer["Processor"] = "Apple Processor";
        }
        public override void BuildScreen()
        {
            computer["Screen"] = "Apple Screen";
        }
    }
}
