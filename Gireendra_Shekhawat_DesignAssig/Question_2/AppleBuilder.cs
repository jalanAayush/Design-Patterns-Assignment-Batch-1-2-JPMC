using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
    {
    internal class AppleBuilder:ComputerBuilder
        {
        public AppleBuilder()
            {
            computer = new Computer("Apple");
            }


        public override void BuildHardDisk()
            {
            computer["hard Disk"] = "1Tb";
            }

        public override void BuildProcessor()
            {
            computer["processor"] = "M1";

            }

        public override void BuildScreen()
            {
            computer["screen"] = "27";

            }

        public override void BuildMotherboard()
            {
            computer["motherboard"] = "MAC_motherboard";
            }


        }
    }
    
