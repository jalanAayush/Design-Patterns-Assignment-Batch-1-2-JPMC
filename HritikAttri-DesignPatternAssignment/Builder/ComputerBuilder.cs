namespace DesignPatternAssignment.Builder
{
    public abstract class ComputerBuilder
    {
        protected Computer computer;

        public Computer Computer
        {
            get { return computer; }
        }

        public abstract void BuildHardDisk();
        public abstract void BuildMotherboard();
        public abstract void BuildProcessor();
        public abstract void BuildScreen();
    }
}
