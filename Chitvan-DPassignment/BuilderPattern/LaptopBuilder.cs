namespace BuilderPattern
{
    class LaptopBuilder : IComputerBuilder
    {
        Computer _computer  = new Computer();
        public void BuildHardDisk()
        {
            this._computer.HardDisk = "1PB";
        }
        public void BuildMotherboard()
        {
            this._computer.Motherboard = "Intel Integrated Motherboard";
        }
        public void BuildProcessor()
        {
            this._computer.Processor = "Ryzen 7000";
        }
        public void BuildScreen()
        {
            this._computer.Screen = "17\" Panel";
        }

        public Computer GetComputer()
        {
            return this._computer;
        }
    }
}