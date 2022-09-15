using BuilderPatternAssignment.Computers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternAssignment.Builder.Companies.TypeOfComputer
{
    internal class LaptopBuilder : ComputerBuilder
    {
        public LaptopBuilder()
        {
            _computer = new Computer("Laptop");
        }

        public override void BuildHardDisk()
        {
            _computer["HardDisk"] = "1 Tera-Byte";
        }

        public override void BuildMotherboard()
        {
            _computer["Motherboard"] = "Mini - ITX";
        }

        public override void BuildProcessor()
        {
            _computer["Processor"] = "intel CORE i7";
        }

        public override void BuildRam()
        {
            _computer["RAM"] = "64 Giga-Byte";
        }
        public override void BuildScreen()
        {
            _computer["Screen"] = "16.5 Inches";
        }
    }
}
