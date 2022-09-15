namespace AbstractFactory_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Console.WriteLine("Please Enter Which type of cars you want to create \n1. Tata \n2. Maruti");
            string type=Console.ReadLine();
            if (type == "Tata")
            {
                TataFactory factory = new TataFactory();
                client.ClientChoice(factory);
            }
            else
            {
                MarutiFactory factory=new MarutiFactory();
                client.ClientChoice(factory);

            }

            
        }
    }
}