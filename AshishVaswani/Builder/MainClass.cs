
namespace Builder_Pattern
{
    class MainClass
    {

        public static void Main()
        {
            ComputerShop? shop;
            ComputerBuilder? builder;
            char cont = 'n';
            int choice = 1;
            do
            {
                Console.Write("Press\n 1. for Laptop Selection\n 2. for Desktop Selection\n 3. for Mac\n Enter your choice : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        builder = new LaptopBuilder();
                        break;
                    case 2:
                        builder = new DesktopBuilder();
                        break;
                    case 3:
                        builder = new MacBuilder();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        return;

                }
                shop = new ComputerShop();
                shop.BuildComputer(builder);
                builder.Computer.DisplayInformation();
                Console.Write("Do you want to continue ? y/N  : ");
                cont = char.Parse(Console.ReadLine());
            } while (cont == 'y' || cont == 'Y');
        }
    }
}