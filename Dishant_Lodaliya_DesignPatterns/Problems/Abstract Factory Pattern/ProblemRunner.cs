using Dishant_Lodaliya_DesignPatterns.Problems.Abstract_Factory_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishant_Lodaliya_DesignPatterns.Problems.Abstract_Factory_Pattern
{
    class ProblemRunner
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
