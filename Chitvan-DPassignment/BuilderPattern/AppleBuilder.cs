namespace BuilderPattern
{
    class AppleBuilder : IComputerBuilder
    {
        Computer _computer = new Computer();
        public void BuildHardDisk()
        {
            this._computer.HardDisk = "256GB";
        }
        public void BuildMotherboard()
        {
            this._computer.Motherboard = "Apple Motherboard";
        }
        public void BuildProcessor()
        {
            this._computer.Processor = "M2";
        }
        public void BuildScreen()
        {
            this._computer.Screen = "13\" Panel";
        }

        public Computer GetComputer()
        {
            return _computer;
        }
    }
}