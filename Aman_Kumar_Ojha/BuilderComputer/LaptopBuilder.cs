using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderComputer
{
    internal class LaptopBuilder : ComputerBuilder
    {
        public LaptopBuilder()
        {
            computer = new Computer("Laptop");
        }

        public override void BuildHardDisk()
        {
            computer["HardDisk"] = "Laptop harddisk"; 
        }

        public override void BuildMotherBoard()
        {
            computer["MotherBoard"] = "laptop MotherBoard";
        }
        public override void BuildProcessor()
        {
            computer["Processor"] = "laptop Processor";
        }
        public override void BuildScreen()
        {
            computer["Screen"] = "Laptop Screen";
        }
    }
}
