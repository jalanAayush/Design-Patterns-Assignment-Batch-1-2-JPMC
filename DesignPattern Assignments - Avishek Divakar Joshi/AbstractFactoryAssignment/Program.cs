using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment
{
    abstract public class Program
    {



       public static void Main()
        {
            CarFactory marutiCar = new MarutiFactory();
            CarWorld marutiWorld = new CarWorld(marutiCar);
            Console.WriteLine("This is " + marutiWorld.showDetails());


        }


    }
}