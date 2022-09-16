using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_Assignment
{
    internal class MacBookBuilder:IComputerFactory
    {
        private Computer computer;

        public MacBookBuilder()
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
