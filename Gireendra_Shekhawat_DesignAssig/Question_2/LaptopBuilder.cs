using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
    {
    internal class LaptopBuilder:ComputerBuilder
        {


        public LaptopBuilder()
            {
            computer = new Computer("Laptop");
            }


        public override void BuildHardDisk()
            {
            computer["hard Disk"] = "16gb";
            }

        public override void BuildProcessor()
            {
            computer["processor"] = "Intel i5 core";

            }

        public override void BuildScreen()
            {
            computer["screen"] = "10";

            }

        public override void BuildMotherboard()
            {
            computer["motherboard"] = "Intel_motherboard";
            }
        }
    }
