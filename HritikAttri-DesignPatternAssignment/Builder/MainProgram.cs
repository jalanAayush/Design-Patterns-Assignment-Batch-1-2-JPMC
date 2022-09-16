namespace DesignPatternAssignment.Builder
{
    public class MainProgram
    {
        public static void Main()
        {
            ComputerBuilder builder;
            Console.WriteLine("Enter type of computer: \n1. Laptop \n2. Desktop \n3. Apple");
            int computerType = int.Parse(Console.ReadLine());

            switch(computerType)
            {
                case 1:
                    builder = new LaptopBuilder();
                    break;
                case 2:
                    builder = new DesktopBuilder();
                    break;
                case 3:
                    builder = new AppleBuilder();
                    break;
                default:
                    return;
            }

            ComputerShop shop = new ComputerShop();
            shop.ConstructComputer(builder);
            builder.Computer.DisplayConfiguration();
        }
    }
}
