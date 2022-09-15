using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
    {
    internal class ComputerShop
        {
        public void Construct(ComputerBuilder builder)
            {

            builder.BuildHardDisk();
            builder.BuildProcessor();
            builder.BuildScreen();
            builder.BuildMotherboard();

            }
        }
    }
