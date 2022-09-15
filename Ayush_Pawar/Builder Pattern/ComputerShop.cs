using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    internal class ComputerShop
    {
        
        public void BuildComputer(ComputerBuilder computerBuilder)
        {
            computerBuilder.BuildProcessor();
            computerBuilder.BuildHardDisk();
            computerBuilder.BuildMotherBoard();
            computerBuilder.BuildScreen();
        }
    }
}
