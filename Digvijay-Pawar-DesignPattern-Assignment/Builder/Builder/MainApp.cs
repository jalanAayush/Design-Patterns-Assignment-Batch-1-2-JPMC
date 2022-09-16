namespace Builder
{
    public class MainApp
    {
        static void Main(string[] args)
        {
            ComputerBuilder computerBuilder;

            Console.WriteLine("Which type of Computer to build? ");

            Console.WriteLine("1.Laptop\n2.Desktop\n3.Apple");

            Console.Write("Enter Computer Type: ");

            int compType = int.Parse(Console.ReadLine());

            switch (compType)
            {
                case 1:
                    computerBuilder = new LaptopBuilder();
                    break;
                case 2:
                    computerBuilder = new DesktopBuilder();
                    break;
                case 3:
                    computerBuilder = new AppleBuilder();
                    break;
                default:
                    computerBuilder = new LaptopBuilder();
                    break;
            }

            Shop shop = new Shop();

            shop.Construct(computerBuilder);

            computerBuilder.Computer.Show();
        }
    }
}