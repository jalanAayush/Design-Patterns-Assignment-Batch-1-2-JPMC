using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPatternAssignment.Computers;

namespace BuilderPatternAssignment.Builder.TypeOfComputer
{
    internal class DesktopBuilder :  ComputerBuilder
    {
        public DesktopBuilder()
        {
            _computer = new Computer("Desktop");
        }

        public override void BuildHardDisk()
        {
            _computer["HardDisk"] = "2 Tera-Byte";
        }

        public override void BuildMotherboard()
        {
            _computer["Motherboard"] = "Standard - ATX";
        }

        public override void BuildProcessor()
        {
            _computer["Processor"] = "intel CORE i5";
        }

        public override void BuildRam()
        {
            _computer["RAM"] = "32 Giga-Byte";
        }
        public override void BuildScreen()
        {
            _computer["Screen"] = "32 Inches";
        }
    }
}
