namespace DesignPatternAssignment.Builder
{
    public class ComputerShop
    {
        public void ConstructComputer(ComputerBuilder builder)
        {
            builder.BuildHardDisk();
            builder.BuildMotherboard();
            builder.BuildProcessor();
            builder.BuildScreen();
        }
    }
}
