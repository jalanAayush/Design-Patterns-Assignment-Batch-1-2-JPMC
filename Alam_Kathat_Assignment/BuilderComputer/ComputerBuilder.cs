using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderComputer
{
    abstract class ComputerBuilder
    {
        protected Computer computer;

        public Computer Computer
        {
            get { return computer; }
        }

        abstract public void BuildHardDisk();
        abstract public void BuildMotherBoard();
        abstract public void BuildProcessor();
        abstract public void BuildScreen();

    }
}
