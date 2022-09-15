namespace BuilderPattern_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Computer type \n1.Desktop \n2.Laptop \n3.Apple \n4.Exit");
            IComputerFactory computer= null;

            LaptopManufacturer computerShop=new LaptopManufacturer();

            string computerType=Console.ReadLine();
            if(computerType == "Desktop")
            {
                computer = new DesktopBuilder();

            }
            else if(computerType == "Laptop")
            {
                computer=new LaptopMaker();
            }
            else if(computerType=="Apple")
            {
                computer = new MacBookBuilder();
            }
            else
            {
                System.Environment.Exit(0);
            }

            computerShop.ConstructComputer(computer);


        }
    }
}