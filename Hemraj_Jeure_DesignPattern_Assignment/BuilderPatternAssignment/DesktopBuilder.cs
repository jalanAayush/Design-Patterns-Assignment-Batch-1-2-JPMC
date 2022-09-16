using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class DesktopBuilder : IComputerBuilder
    {
        private Computer computer;

        public DesktopBuilder()
        {
            computer = new Computer();
            computer.ComputerType = "Desktop";
        }

        public void BuildHardDisk()
        {
            computer.HardDisk = "Desktop HardDisk Added";
        }
        public void BuildMotherboard()
        {
            computer.Motherboard = "Desktop MotherBoard Added";
        }

        public void BuildProcessor()
        {
            computer.Processor = "Desktop Processor Added";
        }

        public void BuildScreen()
        {
            computer.Screen = "Desktop Screen Added";
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