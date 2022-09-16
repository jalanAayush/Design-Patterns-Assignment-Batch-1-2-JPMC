namespace DesignPatternAssignment.Builder
{
    public class LaptopBuilder: ComputerBuilder { 
        public LaptopBuilder() {
            computer = new Computer("Laptop");
        }
        public override void BuildHardDisk()
        {
            computer["hardDisk"] = "Laptop Hard Disk";
        }
        public override void BuildMotherboard()
        {
            computer["motherboard"] = "Laptop Motherboard";
        }
        public override void BuildProcessor()
        {
            computer["processor"] = "Laptop processor";
        }
        public override void BuildScreen()
        {
            computer["screen"] = "Laptop screen";
        }
    }
}
