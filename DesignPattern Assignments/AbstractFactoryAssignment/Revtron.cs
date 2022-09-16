using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment
{
     public  class Revtron : ICarEngine
    {

        public override string showEngine()
        {
            return "THIS IS A REVTRON ENGINE";
        }
    }
}
