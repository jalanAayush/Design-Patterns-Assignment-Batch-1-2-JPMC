using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment
{
    internal interface IComputerBuilder
    {
        public void BuildHardDisk(string hardDisk);
        public void BuildMotherBoard(string motherBoard);
        public void BuildProcessor(string processor);
        public void BuildScreen(string screen);
        public Computer Build();
    }
}
