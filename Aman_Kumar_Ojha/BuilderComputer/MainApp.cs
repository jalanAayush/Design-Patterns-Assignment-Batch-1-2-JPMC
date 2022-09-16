namespace BuilderComputer
{
    class MainApp
    {
        public static void Main()
        {
            char chmenu = ' ';
            do
            {
                ComputerBuilder cb;
                Console.WriteLine("Which type of computer to build? ");
                Console.WriteLine("1.laptop\n2.desktop\n3.apple");
                Console.Write("Enter computer Type: ");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        cb = new LaptopBuilder();
                        break;

                    case 2:
                        cb = new DesktopBuilder();
                        break;

                    case 3:
                        cb = new AppleBuilder();
                        break;

                    default:
                        cb = new LaptopBuilder();
                        break;
                }
                ComputerShop shop = new ComputerShop();
                shop.construct(cb);
                cb.Computer.Show();
                Console.WriteLine("Again want to select from the menu : ");
                chmenu = char.Parse(Console.ReadLine());
            } while (chmenu == 'Y' || chmenu == 'y');
        }
    }
}