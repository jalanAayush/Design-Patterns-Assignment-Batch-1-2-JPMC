using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Assignment
{
    internal class D3 : ICarEngineAction
    {
        public bool carDDisEnginetatus = true;
        public void checkCarEngineStatus()
        {
            if (carDDisEnginetatus)
            {
                Console.WriteLine("Car engine working Properly");
            }
            else
            {
                Console.WriteLine("Damage in the Car Engine");
            }
        }
        public void addCarEngine()
        {
            Console.WriteLine("Car engine added Sucessfully");
            carDDisEnginetatus = true;
        }

        public void remCarEngine()
        {
            Console.WriteLine("Car engine removed from the Car");
        }
        public void replaceCarEngine()
        {
            remCarEngine();
            addCarEngine();
        }
    }
}
