using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment
{
    public abstract class CarFactory
    {
        abstract public ICarEngine createEngine();
        abstract public ICarLight createLight();
        

    }
}
