using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Revtron:CarEngine
    {
        public bool carRevtronEnginetatus = true;

        public void addEngine()
        {
            Console.WriteLine("Car Revtron Engine is added Sucessfully");
            carRevtronEnginetatus = true;
        }

        public void removeEngine()
        {
            Console.WriteLine("Car Revtron Engine is removed from the Car");
        }
        public void checkEngineStatus()
        {
            if (carRevtronEnginetatus)
            {
                Console.WriteLine("Car Revtron Engine is Working Properly");
            }
            else
            {
                Console.WriteLine("Damage in the Car Revtron Engine");
            }
        }
        

        public void replaceEngine()
        {
            removeEngine();
            addEngine();
        }
    }
}
