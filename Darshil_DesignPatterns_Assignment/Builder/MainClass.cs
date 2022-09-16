
using Builder;

public class MainClass
{
    public static void Main()
    {
        char choice = 'y';

        ComputerBuilder builder;

        do
        {
            Console.WriteLine("\n Welcome to the computer Shop !!!");

            Console.WriteLine("\n Availables : ");
            Console.WriteLine("\n 1. Laptop \n 2. Desktop \n 3. Apple \n 4. Exit");

            Console.Write("\n Please select an option : ");
            int cType = int.Parse(Console.ReadLine());

            switch (cType)
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

            CompterShop shop = new CompterShop();

            shop.ConstructComputer(builder);

            builder.Computer.DisplayConfiguration();

            Console.Write("\n Do you want to continue (y|n) : ");
            choice = Char.Parse(Console.ReadLine());
        }
        while (choice == 'y');

    }
}

