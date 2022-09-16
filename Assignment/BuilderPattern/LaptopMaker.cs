using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_Assignment
{
    internal class LaptopMaker : IComputerFactory
    {
        private Computer computer;

        public LaptopMaker()
        {
            computer = new Computer();
        }
        public void BuildHardDisk()
        {
            computer.HardDisk = "Laptop HardDisk";
        }
        public void BuildMotherboard()
        {
            computer.Motherboard = "Laptop MotherBoard";
        }

        public void BuildProcessor()
        {
            computer.Processor = "Laptop Processor";
        }

        public void BuildScreen()
        {
            computer.Screen = "Laptop Screen";
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
