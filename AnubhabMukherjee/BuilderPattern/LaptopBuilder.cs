namespace BuilderPattern
{
    class LaptopBuilder : IComputerBuilder
    {
        public Computer Computer { get; private set; } = new Computer();
        public void BuildHardDisk()
        {
            this.Computer.HardDisk = "1TB";
        }
        public void BuildMotherboard()
        {
            this.Computer.Motherboard = "Intel Motherboard";
        }
        public void BuildProcessor()
        {
            this.Computer.Processor = "Intel Core i7";
        }
        public void BuildScreen()
        {
            this.Computer.Screen = "15\" Panel";
        }
    }
}