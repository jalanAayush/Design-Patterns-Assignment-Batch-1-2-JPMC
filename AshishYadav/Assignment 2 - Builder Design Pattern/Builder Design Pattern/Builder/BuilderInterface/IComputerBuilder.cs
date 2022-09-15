using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern.Builder.BuilderInterface
{
    interface IComputerBuilder
    {
        void BuildHardDisk(); 
        void BuildMotherboard();
        void BuildProcessor();
        void BuildScreen();


        Computer GetComputer();

    }
}
