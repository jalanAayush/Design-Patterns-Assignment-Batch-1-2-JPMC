namespace BuilderPattern
{
    class ComputerShop
    {
        public Computer ConstructComputer()
        {
            var desktopBuilder = new DesktopBuilder();
            desktopBuilder.BuildHardDisk();
            desktopBuilder.BuildMotherboard();
            desktopBuilder.BuildProcessor();
            desktopBuilder.BuildScreen();

            var computer = desktopBuilder.GetComputer();
            return computer;
        }
    }
}