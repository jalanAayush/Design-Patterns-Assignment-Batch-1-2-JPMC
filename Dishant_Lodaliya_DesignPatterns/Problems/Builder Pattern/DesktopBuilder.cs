using Dishant_Lodaliya_DesignPatterns.Problems.Builder_Pattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishant_Lodaliya_DesignPatterns.Problems.Builder_Pattern
{
    internal class DesktopBuider : IComputerBuilder
    {
        private Computer computer;


        public DesktopBuider()
        {
            computer = new Computer();
        }

        public void BuildHardDisk()
        {
            computer.HardDisk = "Desktop_______HardDisk";
        }
        public void BuildMotherboard()
        {
            computer.Motherboard = "Desktop_______MotherBoard";
        }

        public void BuildProcessor()
        {
            computer.Processor = "Desktop_______Processor";
        }

        public void BuildScreen()
        {
            computer.Screen = "Desktop_______Screen";
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
