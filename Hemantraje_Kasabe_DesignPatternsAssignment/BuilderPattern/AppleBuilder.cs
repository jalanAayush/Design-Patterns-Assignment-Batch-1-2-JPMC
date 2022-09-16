using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class AppleBuilder : IComputerBuilder
    {
        private Computer computer;
        public AppleBuilder()
        {
            computer = new Computer();
            computer.ComputerType = "Apple";
        }
        public void BuildHardDisk()
        {
            computer.HardDisk = "Apple HardDisk Added";
        }
        public void BuildMotherboard()
        {
            computer.Motherboard = "Apple MotherBoard Added";
        }
        public void BuildProcessor()
        {
            computer.Processor = "Apple Processor Added";
        }
        public void BuildScreen()
        {
            computer.Screen = "Apple Screen Added";
        }
        public Computer Build()
        {
            return computer;
        }
        public void DisplayConfig()
        {
            computer.DisplayConfiguration();
        }
    }
}
