using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment
{
    class Computer
    {
        private string computerType;
        private string hardDisk;
        private string motherBoard;
        private string processor;
        private string screen;

        public Computer(string computerType, string hardDisk, string motherBoard, string processor, string screen)
        {
            this.computerType = computerType;
            this.hardDisk = hardDisk;
            this.motherBoard = motherBoard;
            this.processor = processor;
            this.screen = screen;
        }

        public void DisplayConfiguration()
        {
            Console.WriteLine("Computer Type: " + this.computerType);
            Console.WriteLine("Hard disk: " + this.hardDisk);
            Console.WriteLine("mother board: " + this.motherBoard);
            Console.WriteLine("processor: " + this.processor);
            Console.WriteLine("screen: " + this.screen);
        }
    }
}
