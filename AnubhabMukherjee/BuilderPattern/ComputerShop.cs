namespace BuilderPattern
{
    class ComputerShop
    {
        public Computer ConstructComputer()
        {
            DesktopBuilder desktopBuilder = new();
            desktopBuilder.BuildHardDisk();
            desktopBuilder.BuildMotherboard();
            desktopBuilder.BuildProcessor();
            desktopBuilder.BuildScreen();

            var computer = desktopBuilder.Computer;
            return computer;
        }
    }
}