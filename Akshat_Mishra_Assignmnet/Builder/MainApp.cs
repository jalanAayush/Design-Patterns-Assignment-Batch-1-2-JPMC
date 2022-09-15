using System;

namespace Builder
{
    public class MainApp
    {
        public static void Main()
        {
            ComputerBuilder Cbuilder;

            Console.WriteLine("Which type of Computer to build? ");

            Console.WriteLine("1.Laptop\n2.Desktop\n3.Apple");
            
            Console.Write("Enter Computer Type: ");

            int CType = int.Parse(Console.ReadLine());

            switch(CType)
            {
                case 1:
                    Cbuilder = new Laptop();
                    break;
                case 2:
                    Cbuilder = new Desktop();
                    break;
                case 3:
                    Cbuilder = new Apple();
                    break;
                default:
                    Cbuilder = new Laptop();
                    break;
            }

            Shop shop = new Shop();
        
            shop.Construct(Cbuilder);
            Cbuilder.Computer.Show();

        }
    }
}
