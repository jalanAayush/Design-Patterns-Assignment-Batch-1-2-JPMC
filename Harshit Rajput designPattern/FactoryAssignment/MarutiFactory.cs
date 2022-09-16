using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAssignment
{
    internal class MarutiFactory : IVehicleFactory
    {
        public ICarEngine installEngine(string type)
        {
            if (type.Equals(typeof(DDis).Name)){
                return new DDis();
            }
            else {
                return new Revtron();
            }
        }
        public ICarLight installLight(string type)
        {
            if (type.Equals(typeof(DDis).Name)){
                return new Helogan();
            }
            else {
                return new LED();
            }
        }
    }
}
