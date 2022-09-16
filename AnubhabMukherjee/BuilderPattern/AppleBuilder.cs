namespace BuilderPattern
{
    class AppleBuilder : IComputerBuilder
    {
        public Computer Computer { get; private set; } = new Computer();
        public void BuildHardDisk()
        {
            this.Computer.HardDisk = "512GB";
        }
        public void BuildMotherboard()
        {
            this.Computer.Motherboard = "Apple Motherboard";
        }
        public void BuildProcessor()
        {
            this.Computer.Processor = "M1";
        }
        public void BuildScreen()
        {
            this.Computer.Screen = "12\" Panel";
        }
    }
}