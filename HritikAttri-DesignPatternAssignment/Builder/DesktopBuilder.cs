namespace DesignPatternAssignment.Builder
{
    public class DesktopBuilder : ComputerBuilder { 
        public DesktopBuilder() {
            computer = new Computer("Desktop");
        }

        public override void BuildHardDisk()
        {
            computer["hardDisk"] = "Desktop Hard Disk";
        }
        public override void BuildMotherboard()
        {
            computer["motherboard"] = "Desktop Motherboard";
        }
        public override void BuildProcessor()
        {
            computer["processor"] = "Desktop Processor";
        }
        public override void BuildScreen()
        {
            computer["screen"] = "Desktop Screen";
        }
    }
}
