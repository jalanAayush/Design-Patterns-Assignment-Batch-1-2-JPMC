namespace BuilderPattern
{
    class DesktopBuilder : IComputerBuilder
    {
        public Computer Computer { get; private set; } = new Computer();
        public void BuildHardDisk()
        {
            this.Computer.HardDisk = "2TB";
        }
        public void BuildMotherboard()
        {
            this.Computer.Motherboard = "Asus Motherboard";
        }
        public void BuildProcessor()
        {
            this.Computer.Processor = "Ryzen";
        }
        public void BuildScreen()
        {
            this.Computer.Screen = "27\" IPS Panel";
        }
    }
}