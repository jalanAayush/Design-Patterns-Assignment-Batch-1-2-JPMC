using Builder_Design_Pattern.Builder.BuilderInterface;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern
{
    internal class Director
    {
        public void BuildComputer(IComputerBuilder computerBuilder)
        {
            computerBuilder.BuildHardDisk();
            computerBuilder.BuildMotherboard();
            computerBuilder.BuildProcessor();
            computerBuilder.BuildScreen();
        }
    }
}
