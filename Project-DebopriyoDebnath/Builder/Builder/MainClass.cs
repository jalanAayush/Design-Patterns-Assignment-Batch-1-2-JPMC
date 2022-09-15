// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Builder;

public class MainClass
{
    public static void Main()
    {
        ComputerBuilder builder;

        Console.WriteLine("\n Welcome to the computer Shop !!!");

        Console.WriteLine("\n Availables : ");
        Console.WriteLine("\n 1. Laptop \n 2. Desktop \n 3. Apple");

        Console.Write("\n Please select an option : ");
        int cType = int.Parse(Console.ReadLine());

        switch(cType)
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
                builder = new LaptopBuilder();
                break;
        }

        CompterShop shop = new CompterShop();

        shop.ConstructComputer(builder);

        builder.Computer.DisplayConfiguration();
    }
}


