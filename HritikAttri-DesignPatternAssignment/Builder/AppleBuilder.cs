using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment.Builder
{
    public class AppleBuilder: ComputerBuilder
    {
        public AppleBuilder()
        {
            computer = new Computer("Apple");
        }

        public override void BuildHardDisk()
        {
            computer["hardDisk"] = "Apple Hard Disk";
        }
        public override void BuildMotherboard()
        {
            computer["motherBoard"] = "Apple Motherboard";
        }
        public override void BuildProcessor()
        {
            computer["processor"] = "Apple processor";
        }
        public override void BuildScreen()
        {
            computer["screen"] = "Apple screen";
        }
    }
}
