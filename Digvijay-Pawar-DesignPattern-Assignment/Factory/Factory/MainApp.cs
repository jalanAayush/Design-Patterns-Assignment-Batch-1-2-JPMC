namespace Factory
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            VehicleFactory factory;
            Console.WriteLine("Please Enter Which type of cars you want to create \n1. Tata \n2. Maruti");
            int type = int.Parse(Console.ReadLine());

            switch (type)
            {
                case 1:
                    factory = new Tata();
                    break;
                case 2:
                    factory = new Maruti();
                    break;
                default:
                    return;
                
            }

            client.createClientChoice(factory);

        }
    }
}