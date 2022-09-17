using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryAssignment
{
     public class MarutiFactory : CarFactory
    {
        
       
        
        public override ICarEngine createEngine()
        {
            return new Revtron();
            
        }
        public override ICarLight createLight()
        {
            return new Halogen();

        }


    }
}
