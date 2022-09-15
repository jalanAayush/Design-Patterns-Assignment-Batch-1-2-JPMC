namespace AbsoluteFactoryPattern
{
    class MainClass
    {

        public static void Main()
        {
            IVehicleFactory factory;
            CarShowroom showroom;
            char cont;
            int choice;
            do
            {
                Console.Write("\nPress\n1. for TATA car \n2.for Maruti car\n Enter you choice : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        factory = new TataFactory();

                        break;
                    case 2:
                        factory = new MarutiFactory();

                        break;
                    default:return;
                }
                showroom=new CarShowroom(factory);
                showroom.DisplayBrochure();
                Console.Write("Do you want to continue? [y/N] : ");
                cont = char.Parse(Console.ReadLine());
            } while (cont == 'y' || cont == 'Y');
            


        }
    }
}