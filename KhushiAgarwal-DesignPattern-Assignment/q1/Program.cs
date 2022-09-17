namespace q1
{
    
        internal class Program
        {
            static void Main(string[] args)
            {
                Client client = new Client();
                IVehicleFactory factory;
                Console.WriteLine("Please Enter Which type of cars you want to create \n1. Tata \n2. Maruti");
                string type = Console.ReadLine();
                if (type == "Tata")
                {
                    factory = new TataFactory();

                }
                else
                {
                    factory = new MarutiFactory();

                }

                client.createClientChoice(factory);


            }
        }
    
}