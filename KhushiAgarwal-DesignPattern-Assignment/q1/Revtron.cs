﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    
    internal class Revtron : ICarEngine
    {

        public bool carRevtronEnginetatus = true;
        public void checkCarEngineStatus()
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
        public void addCarEngine()
        {
            Console.WriteLine("Car Revtron Engine is added Sucessfully");
            carRevtronEnginetatus = true;
        }

        public void removeCarEngine()
        {
            Console.WriteLine("Car Revtron Engine is removed from the Car");
        }

        public void replaceCarEngine()
        {
            removeCarEngine();
            addCarEngine();
        }
    }
}
