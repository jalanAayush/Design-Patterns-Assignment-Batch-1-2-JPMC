using Builder_Design_Pattern.Builder;
using Builder_Design_Pattern.Builder.BuilderInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern.Product
{
    class AppleBuilder : IComputerBuilder
    {

        Computer apple = new Computer();
        public void BuildHardDisk()
        {
            apple.HDD = "256GB";
        }

        public void BuildMotherboard()
        {
            apple.Motherboard = "Apple Integrated";
        }

        public void BuildProcessor()
        {
            apple.Processor = "M1";
        }

        public void BuildScreen()
        {
            apple.Screen = "Retina";
        }

        public Computer GetComputer()
        {
            return apple;
        }
    }
}
