using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment
{
    internal class ComputerShop
    {
        public static Computer buildLaptop(
            IComputerBuilder builder,
            string hardDisk,
            string motherBoard,
            string processor,
            string screen
            )
        {
            builder.BuildHardDisk(hardDisk);
            builder.BuildProcessor(processor);
            builder.BuildMotherBoard(motherBoard);
            builder.BuildScreen(screen);
            return builder.Build();
        }
    }
}
