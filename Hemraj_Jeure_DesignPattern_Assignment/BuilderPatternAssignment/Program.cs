namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter type of the Computer \n1.Desktop \n2.Laptop \n3.Apple");
            IComputerBuilder computer;

            ComputerShop computerShop = new ComputerShop();

            string? computerType = Console.ReadLine();
            if (computerType == "Desktop")
            {
                computer = new DesktopBuilder();

            }
            else if (computerType == "Laptop")
            {
                computer = new LaptopBuilder();
            }
            else
            {
                computer = new AppleBuilder();
            }

            computerShop.ConstructComputer(computer);
        }
    }
}