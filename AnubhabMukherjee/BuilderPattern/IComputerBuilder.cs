namespace BuilderPattern
{
    interface IComputerBuilder
    {
        Computer Computer { get; }
        void BuildHardDisk();
        void BuildMotherboard();
        void BuildProcessor();
        void BuildScreen();
    }
}