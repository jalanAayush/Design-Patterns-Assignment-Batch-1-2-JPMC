using FactoryDesignPattern;
using FactoryDesignPattern.Factories;
using FactoryDesignPattern.FactoryInterface;
using System;

namespace AbstractFactoryDesignPattern
{
    class MainClass
    {
      
        public static void Main()
        {
         
            IVehicleFactory MarutiFactory = new MarutiFactory();
            Client client1 = new Client(MarutiFactory);
            
            client1.RunFactory();

           
            IVehicleFactory TataFactory = new TataFactory();
            Client client2 = new Client(TataFactory);
            client2.RunFactory();
    
            Console.ReadKey();
        }
    }
   
}
