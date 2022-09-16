using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class ComputerBuilder
    {
        protected Computer comp;

        public Computer Computer
        {
            get { return comp; }
        }
        public abstract void HardDisk();
        public abstract void MotherBoard();
        public abstract void Processor();
        public abstract void Screen();
    }
}
