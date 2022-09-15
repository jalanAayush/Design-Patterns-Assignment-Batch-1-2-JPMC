using Builder_Design_Pattern.Builder;
using Builder_Design_Pattern.Builder.BuilderInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern.Product
{
    internal class DesktopBuilder : IComputerBuilder
    {

        Computer desktop = new Computer();
        public void BuildHardDisk()
        {
            desktop.HDD = "1TB";
        }

        public void BuildMotherboard()
        {
            desktop.Motherboard = "Asus B750";
        }

        public void BuildProcessor()
        {
            desktop.Processor = "Intel i9";
        }

        public void BuildScreen()
        {
            desktop.Screen = "OLED";
        }

        public Computer GetComputer()
        {
            return desktop;
        }
    }
}
