
namespace BuilderPattern
{
    class MainClass
    {

        public static void Main()
        {
            ComputerShop? shop;
            BuilderComputer? builder;
            char cont='n';
            int choice =1;
            do
            {
                Console.Write("Press\n 1.Desktop\n 2.Mac \n 3.Laptop\n Enter your choice : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        builder = new BuilderDesktop();
                        break;
                    case 2:
                        builder = new BuilderMac();
                        break;
                    case 3: 
                        builder = new BuilderLaptop();
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