using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Revtron : ICarEngine
    {

        public bool carRevtronEnginetatus = true;
        public void CheckCarEngineStatus()
        {
            if (carRevtronEnginetatus)
            {
                Console.WriteLine("Car Revtron Engine Working ");
            }
            else
            {
                Console.WriteLine("Damage detected in the Car Revtron Engine");
            }
        }
        public void AddCarEngine()
        {
            Console.WriteLine("Car Revtron Engine installed");
            carRevtronEnginetatus = true;
        }

        public void RemoveCarEngine()
        {
            Console.WriteLine("Car Revtron Engine removed");
        }

        public void ReplaceCarEngine()
        {
            RemoveCarEngine();
            AddCarEngine();
        }
    }
}
