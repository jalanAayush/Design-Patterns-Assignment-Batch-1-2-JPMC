
namespace Builder
{

    abstract class ComputerBuilder
    {
        protected Computer computer;

        public Computer Computer
        {
            get { return computer; }
        }

        public abstract void HardDisk();
        public abstract void MotherBoard();
        public abstract void Processor();
        public abstract void Screen();
    }
}
