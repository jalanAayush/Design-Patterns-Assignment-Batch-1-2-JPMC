using BuilderPatternAssignment.Builder;
using BuilderPatternAssignment.Builder.Companies.TypeOfComputer;
using BuilderPatternAssignment.Shop.Companies;
using BuilderPatternAssignment.Builder.TypeOfComputer;
using BuilderPatternAssignment.Shop;
namespace BuilderPatternAssignment
{
    internal class ComputerShopApp
    {
        static void Main(string[] args)
        {
            ComputerBuilder computerBuilder;
            ComputerShop computerShop;
            string company;
            Console.WriteLine("Welcome To Star Technologies");
            Console.WriteLine();
            Console.WriteLine("Would You Like To buy a Computer?");
            Console.Write("Choose (Y/N) : ");
            string choice = Console.ReadLine();
            Console.WriteLine();
            if (choice.ToUpper() == "Y")
            {
                Console.WriteLine("Choose Company");
                Console.WriteLine(" 1.Apple");
                Console.WriteLine(" 2.Microsoft");
                Console.Write("Company-Name : ");
                company = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("Choose the computer type : ");
                Console.WriteLine(" 1.Desktop");
                Console.WriteLine(" 2.Laptop");
                Console.Write("Type ( 1 or 2 ): ");
                int typeOfComputer = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("**************************************");
                Console.WriteLine();
                switch (typeOfComputer)
                {
                    case 1:
                        computerBuilder = new DesktopBuilder();
                        break;

                    case 2:
                        computerBuilder = new LaptopBuilder();
                        break;
                    default:
                        computerBuilder = new DesktopBuilder();
                        break;
                }

                switch (company.ToUpper())
                {
                    case "APPLE":
                        computerShop = new AppleShop();
                        break;
                    case "MICROSOFT":
                        computerShop = new MicrosoftShop();
                        break;
                    default:
                        computerShop = new AppleShop();
                        break;
                }
                computerShop.Construct(computerBuilder);
                computerBuilder.Computer.ShowCase();
            }
            else
            {
                Console.WriteLine("Thank You For Visiting");
                Environment.Exit(0);
            }
        }
    }
}