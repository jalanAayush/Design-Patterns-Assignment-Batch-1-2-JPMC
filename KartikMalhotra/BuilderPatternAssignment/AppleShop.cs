using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPatternAssignment.Builder;
namespace BuilderPatternAssignment.Shop.Companies
{
    internal class AppleShop : ComputerShop
    {
        public AppleShop()
        {
            Console.WriteLine("Apple - Computers");
        }
        public override void Construct(ComputerBuilder computerbuilder)
        {
            computerbuilder.BuildHardDisk();
            computerbuilder.BuildProcessor();
            computerbuilder.BuildRam();
            computerbuilder.BuildMotherboard();
            computerbuilder.BuildScreen();
        }
    }
}
