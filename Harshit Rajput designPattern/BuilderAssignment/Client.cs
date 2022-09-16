using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment
{
    internal class Client
    {
        public static void Main()
        {
            string hardDisk, motherBoard, processor, screen;
            Console.WriteLine("Choose computer type:"); ;
            Console.WriteLine("1. Laptop\n2. Desktop\n3.Apple\nEnter option: ");
            int type = int.Parse(Console.ReadLine());
            IComputerBuilder builder;
            if (type == 1)
            {
                Console.Write("Enter hard disk name: ");
                hardDisk = Console.ReadLine();
                Console.Write("Enter motherboard name: ");
                motherBoard = Console.ReadLine();
                Console.Write("Enter processor name: ");
                processor = Console.ReadLine();
                Console.Write("Enter screen name: ");
                screen = Console.ReadLine();
                builder = new LaptopBuilder();
                Computer computer = ComputerShop.buildLaptop(builder, hardDisk, motherBoard, processor, screen);
                computer.DisplayConfiguration();
            }
            else if (type == 2)
            {
                Console.Write("Enter hard disk name: ");
                hardDisk = Console.ReadLine();
                Console.Write("Enter motherboard name: ");
                motherBoard = Console.ReadLine();
                Console.Write("Enter processor name: ");
                processor = Console.ReadLine();
                Console.Write("Enter screen name: ");
                screen = Console.ReadLine();
                builder = new DesktopBuilder();
                Computer computer = ComputerShop.buildLaptop(builder, hardDisk, motherBoard, processor, screen);
                computer.DisplayConfiguration();
            }
            else if (type == 3)
            {
                Console.Write("Enter hard disk name: ");
                hardDisk = Console.ReadLine();
                Console.Write("Enter motherboard name: ");
                motherBoard = Console.ReadLine();
                Console.Write("Enter processor name: ");
                processor = Console.ReadLine();
                Console.Write("Enter screen name: ");
                screen = Console.ReadLine();
                builder = new AppleBuilder();
                Computer computer = ComputerShop.buildLaptop(builder, hardDisk, motherBoard, processor, screen);
                computer.DisplayConfiguration();
            }
            else
            {
                Console.WriteLine("Invalid value");
                return;
            }


        }
    }
}
