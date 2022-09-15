using Builder_Design_Pattern.Builder;
using Builder_Design_Pattern.Builder.BuilderInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern.Product
{
    internal class LaptopBuilder : IComputerBuilder
    {

        Computer laptop = new Computer();
        public void BuildHardDisk()
        {
            laptop.HDD = "512GB";
        }

        public void BuildMotherboard()
        {
            laptop.Motherboard = "Asus Integrated";
        }

        public void BuildProcessor()
        {
            laptop.Processor = "Intel i9";
        }

        public void BuildScreen()
        {
            laptop.Screen = "LED";
        }

        public Computer GetComputer()
        {
            return laptop;
        }
    }
}
