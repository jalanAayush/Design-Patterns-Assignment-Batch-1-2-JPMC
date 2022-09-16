using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class DDI : CarEngine
    {
        public bool carDDisEnginetatus = true;
        public void addEngine()
        {
            Console.WriteLine("Car DDis Engine is added Sucessfully");
            carDDisEnginetatus = true;
        }
        public void removeEngine()
        {
            Console.WriteLine("Car DDis Engine is removed from the Car");
        }
        public void checkEngineStatus()
        {
            if (carDDisEnginetatus)
            {
                Console.WriteLine("Car DDis Engine is Working");
            }
            else
            {
                Console.WriteLine("Damage in the Car DDis Engine");
            }
        }
        
        public void replaceEngine()
        {
            removeEngine();
            addEngine();
        }
    }
}
