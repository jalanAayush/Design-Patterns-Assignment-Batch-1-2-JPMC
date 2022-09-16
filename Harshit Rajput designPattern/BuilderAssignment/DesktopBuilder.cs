using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment
{
    internal class DesktopBuilder : IComputerBuilder
    {
        private string _hardDisk;
        private string _motherBoard;
        private string _processor;
        private string _screen;
        public void BuildHardDisk(string hardDisk)
        {
            _hardDisk = hardDisk;
        }

        public void BuildMotherBoard(string motherBoard)
        {
            _motherBoard = motherBoard;
        }

        public void BuildProcessor(string processor)
        {
            _processor = processor;
        }

        public void BuildScreen(string screen)
        {
            _screen = screen;
        }
        public Computer Build()
        {
            return new Computer("Desktop", _hardDisk, _motherBoard, _processor, _screen);
        }
    }
}
