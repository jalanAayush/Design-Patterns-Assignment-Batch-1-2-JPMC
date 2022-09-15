using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
    {
    abstract class ComputerBuilder
        {

        protected Computer computer;

        public Computer Computer
            {
            get { return computer; }
            }
        public abstract void BuildHardDisk();
        public abstract void BuildProcessor();
        public abstract void BuildScreen();
        public abstract void BuildMotherboard();



        }
    }
