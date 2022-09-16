using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal interface IComputerBuilder
    {
        public void BuildHardDisk();
        public void BuildMotherboard();
        public void BuildProcessor();
        public void BuildScreen();
        public Computer Build();
        public void DisplayConfig();
    }
}
