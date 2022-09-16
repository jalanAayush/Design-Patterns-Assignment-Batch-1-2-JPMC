using System;
using System.Collections.Generic;
namespace Builder
{
    class Shop
    {
       
        public void Construct(ComputerBuilder computerbuilder)
        {
            computerbuilder.HardDisk();
            computerbuilder.MotherBoard();
            computerbuilder.Processor();
            computerbuilder.Screen();
        }

    }
}
