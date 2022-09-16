using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_Assignment
{
    internal class AppleBuilder:IComputerBuilder
    {
        private Computer computer;

        public AppleBuilder()
        {
            computer = new Computer();
        }

        public void BuildHardDisk()
        {
            computer.HardDisk = "Apple HardDisk";
        }
        public void BuildMotherboard()
        {
            computer.Motherboard = "Apple MotherBoard";
        }

        public void BuildProcessor()
        {
            computer.Processor = "Apple Processor";
        }

        public void BuildScreen()
        {
            computer.Screen = "Apple Screen";
        }

        public Computer build()
        {
            return computer;
        }

        public void displayConfig()
        {
            computer.DisplayConfiguration();
        }
    }
}
