using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPatternAssignment.Builder;

namespace BuilderPatternAssignment.Shop.Companies
{
    internal class MicrosoftShop : ComputerShop
    {
        public MicrosoftShop()
        {
            Console.WriteLine("Microsoft - Computers");
        }
        public override void Construct(ComputerBuilder computerbuilder)
        {
            computerbuilder.BuildHardDisk();
            computerbuilder.BuildMotherboard();
            computerbuilder.BuildProcessor();
            computerbuilder.BuildRam();
            computerbuilder.BuildScreen();
        }
    }
}