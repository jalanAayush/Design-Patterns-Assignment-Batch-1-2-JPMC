namespace BuilderPattern
{
    class MainClass
    {
        static void Main()
        {
            var shop = new ComputerShop();

            var computer = shop.ConstructComputer();

            Console.WriteLine(computer.Configuration);
        }
    }
}