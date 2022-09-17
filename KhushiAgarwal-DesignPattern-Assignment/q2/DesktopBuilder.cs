using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
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
            computer.HardDisk = "Desktop HardDisk";
        }
        public void BuildMotherboard()
        {
            computer.Motherboard = "Desktop MotherBoard";
        }

        public void BuildProcessor()
        {
            computer.Processor = "Desktop Processor";
        }

        public void BuildScreen()
        {
            computer.Screen = "Desktop Screen";
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
