using Dishant_Lodaliya_DesignPatterns.Problems.Abstract_Factory_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishant_Lodaliya_DesignPatterns.Problems.Abstract_Factory_Pattern
{
    class MarutiFactory : IVehicleFactory
    {
        public ICarLight CreateCarLight()
        {
            return new Halogen();
        }
        public ICarEngine CreateCarEngine()
        {
            return new DDis();
        }
    }
}
