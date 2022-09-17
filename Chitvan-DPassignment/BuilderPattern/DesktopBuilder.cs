namespace BuilderPattern
{
    class DesktopBuilder : IComputerBuilder
    {
        Computer _computer  = new Computer();
        public void BuildHardDisk()
        {
            this._computer.HardDisk = "2GB";
        }
        public void BuildMotherboard()
        {
            this._computer.Motherboard = "Asus ROG Motherboard";
        }
        public void BuildProcessor()
        {
            this._computer.Processor = "Ryzen 7000";
        }
        public void BuildScreen()
        {
            this._computer.Screen = "15\" VA Panel";
        }

        public Computer GetComputer()
        {
            return this._computer;

        }
    }
}