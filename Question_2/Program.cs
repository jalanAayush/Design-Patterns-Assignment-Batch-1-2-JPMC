namespace Question_2
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Console.WriteLine("Hello, World!");

            ComputerBuilder builder;
            ComputerShop shop = new ComputerShop();


            builder = new LaptopBuilder();
            shop.Construct(builder);
            builder.Computer.DisplayConfiguration();

            builder = new DesktopBuilder();
            shop.Construct(builder);
            builder.Computer.DisplayConfiguration();

            builder = new AppleBuilder();
            shop.Construct(builder);
            builder.Computer.DisplayConfiguration();
            }
        }
    }