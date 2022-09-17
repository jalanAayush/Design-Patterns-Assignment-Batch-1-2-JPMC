using Dishant_Lodaliya_DesignPatterns.Problems.Builder_Pattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishant_Lodaliya_DesignPatterns.Problems.Builder_Pattern
{
    internal class LaptopBuilder : IComputerBuilder
    {
        private Computer computer;

        public LaptopBuilder()
        {
            computer = new Computer();
        }

        public void BuildHardDisk()
        {
            computer.HardDisk = "Laptop_______HardDisk";
        }
        public void BuildMotherboard()
        {
            computer.Motherboard = "Laptop_______MotherBoard";
        }

        public void BuildProcessor()
        {
            computer.Processor = "Laptop_______Processor";
        }

        public void BuildScreen()
        {
            computer.Screen = "Laptop_______Screen";
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
