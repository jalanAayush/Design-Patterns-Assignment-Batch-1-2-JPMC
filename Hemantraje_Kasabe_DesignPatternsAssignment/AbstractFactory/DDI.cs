using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
     class DDI : ICarEngine
    {
        public bool carDDisEnginetatus = true;
        public void CheckCarEngineStatus()
        {
            if (carDDisEnginetatus)
            {
                Console.WriteLine("Car DDI Engine Working");
            }
            else
            {
                Console.WriteLine("Damage Detected in the Car DDI Engine");
            }
        }
        public void AddCarEngine()
        {
            Console.WriteLine("Car DDI Engine Installed");
            carDDisEnginetatus = true;
        }

        public void RemoveCarEngine()
        {
            Console.WriteLine("Car DDI Engine Removed");
        }

        public void ReplaceCarEngine()
        {
            // Replace = Remove + Add new
            RemoveCarEngine();
            AddCarEngine();
        }
    }
}
