using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class ComputerBuilder
    {
        protected Computer computer;

        public Computer Computer
        {
            get { return this.computer; }
        }

        public abstract void BuildHardDisk();
        public abstract void BuildMotherBoard();
        public abstract void BuildProcessor();
        public abstract void BuildScreen();
    }
}
