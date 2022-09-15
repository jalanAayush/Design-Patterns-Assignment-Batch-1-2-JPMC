using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern_Assignment
{
    interface IComputerFactory
    {
        public void BuildHardDisk();
        public void BuildMotherboard();

        public void BuildProcessor();

        public void BuildScreen();

        public Computer build();

        public void displayConfig();




    }
}
