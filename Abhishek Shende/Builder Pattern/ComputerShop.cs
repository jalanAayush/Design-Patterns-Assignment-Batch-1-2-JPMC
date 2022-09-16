using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class ComputerShop
    {
        
        public void BuildComputer(BuilderComputer computerBuilder)
        {
            computerBuilder.BuildProcessor();
            computerBuilder.BuildHardDisk();
            computerBuilder.BuildMotherBoard();
            computerBuilder.BuildScreen();
        }
    }
}
