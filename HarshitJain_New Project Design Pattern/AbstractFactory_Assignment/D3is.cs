using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Assignment
{
    internal class D3is:ICarEngineAction
    {
        public bool carDDisEnginetatus = true;
        public  void checkCarEngineStatus()
        {
            if (carDDisEnginetatus)
            {
                Console.WriteLine("Car D3is Engine is Working Properly");
            }
            else
            {
                Console.WriteLine("Damage in the Car DDis Engine");
            }
        }
        public   void addCarEngine()
        {
            Console.WriteLine("Car D3is Engine is added Sucessfully");
            carDDisEnginetatus = true;
        }

        public   void removeCarEngine()
        {
            Console.WriteLine("Car D3is Engine is removed from the Car");
        }

        public   void replaceCarEngine()
        {
            removeCarEngine();
            addCarEngine();
        }
    }
}
