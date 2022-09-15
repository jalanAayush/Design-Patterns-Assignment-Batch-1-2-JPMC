using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
    {
    internal class DesktopBuilder:ComputerBuilder
        {
        public DesktopBuilder()
            {
            computer = new Computer("Desktop");
            }


        public override void BuildHardDisk()
            {
            computer["hard Disk"] = "128gb";
            }

        public override void BuildProcessor()
            {
            computer["processor"] = "Intel i7 core";

            }

        public override void BuildScreen()
            {
            computer["screen"] = "32";

            }

        public override void BuildMotherboard()
            {
            computer["motherboard"] = "Desktop_motherboard";
            }
        }
    }
    
