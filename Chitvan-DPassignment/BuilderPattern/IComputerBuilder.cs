namespace BuilderPattern
{
    interface IComputerBuilder
    {
        Computer GetComputer(); 
        void BuildHardDisk();
        void BuildMotherboard();
        void BuildProcessor();
        void BuildScreen();
    }
}