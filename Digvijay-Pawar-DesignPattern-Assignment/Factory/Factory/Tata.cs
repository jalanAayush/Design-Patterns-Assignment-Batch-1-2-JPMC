using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Tata:VehicleFactory
    {
        public CarEngine createCarEngine()
        {
            return new DDI();
        }

        public CarLight createCarLight()
        {
            return new Helogan();
        }
    }
}
