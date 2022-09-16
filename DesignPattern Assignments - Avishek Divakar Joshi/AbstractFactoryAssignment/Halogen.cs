using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment
{
    public class Halogen : ICarLight
    {
        public  override string showLight()
        {
            return "THIS IS HALOGEN LIGHT";
        }

    }
}
