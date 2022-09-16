using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class LaptopBuilder : IComputerBuilder
    {

        private Computer computer;
        public LaptopBuilder()
        {
            computer = new Computer();
            computer.ComputerType = "Laptop";
        }
        public void BuildHardDisk()
        {
            computer.HardDisk = "Laptop HardDisk Added";
        }
        public void BuildMotherboard()
        {
            computer.Motherboard = "Laptop MotherBoard Added";
        }
        public void BuildProcessor()
        {
            computer.Processor = "Laptop Processor Added";
        }
        public void BuildScreen()
        {
            computer.Screen = "Laptop Screen Added";
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