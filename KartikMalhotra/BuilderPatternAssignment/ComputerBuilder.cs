using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPatternAssignment.Computers;

namespace BuilderPatternAssignment.Builder
{
    abstract class ComputerBuilder
    {
        protected Computer _computer;

        public Computer Computer
        {
            get { return _computer; }
        }

        public abstract void BuildHardDisk();
        public abstract void BuildMotherboard();
        public abstract void BuildProcessor();
        public abstract void BuildRam();
        public abstract void BuildScreen();
    }
}
