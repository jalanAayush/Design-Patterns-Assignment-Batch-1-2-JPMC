using Dishant_Lodaliya_DesignPatterns.Problems.Builder_Pattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishant_Lodaliya_DesignPatterns.Problems.Builder_Pattern
{
    class ProgramRunner
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Computer \n1.Desktop \n2.Laptop \n3.Apple");
            IComputerBuilder computer;

            ComputerShop computerShop = new ComputerShop();

            string computerType = Console.ReadLine();
            if (computerType == "Desktop")
            {
                computer = new DesktopBuider();

            }
            else if (computerType == "Laptop")
            {
                computer = new LaptopBuilder();
            }
            else
            {
                computer = new AppleBuilder();
            }

            computerShop.ConstructComputer(computer);


        }
    }
}
