using Dishant_Lodaliya_DesignPatterns.Problems.Builder_Pattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishant_Lodaliya_DesignPatterns.Problems.Builder_Pattern
{
    internal class AppleBuilder : IComputerBuilder
    {
        private Computer computer;

        public AppleBuilder()
        {
            computer = new Computer();
        }

        public void BuildHardDisk()
        {
            computer.HardDisk = "Apple_______HardDisk";
        }
        public void BuildMotherboard()
        {
            computer.Motherboard = "Apple_______MotherBoard";
        }

        public void BuildProcessor()
        {
            computer.Processor = "Apple_______Processor";
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
