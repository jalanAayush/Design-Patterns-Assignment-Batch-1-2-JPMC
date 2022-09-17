﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
   
    internal class TataFactory : IVehicleFactory
    {
        public ICarEngine createCarEngine()
        {
            return new DDis();
        }

        public ICarLight createCarLight()
        {
            return new Helogan();
        }
    }
}
