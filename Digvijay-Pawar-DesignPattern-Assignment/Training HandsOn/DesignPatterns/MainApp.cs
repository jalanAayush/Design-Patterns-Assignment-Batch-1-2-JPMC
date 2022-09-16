using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            //Factory Method

            //ContinentFacotry africa = new AfricaFactory();
            //AnimalWorld world = new AnimalWorld(africa);
            //world.RunFoodChain();

            //ContinentFacotry america = new AmericanFactory();
            //world = new AnimalWorld(america);
            //world.RunFoodChain();


            //Singleton Method
            Employees emp1 = Employees.GetEmployee();
            Employees emp2 = Employees.GetEmployee();
            Employees emp3 = Employees.GetEmployee();

            if (emp1 == emp2 && emp2 == emp3)
            {
                Console.WriteLine("Same Instance");
            }

        }
    }
}
