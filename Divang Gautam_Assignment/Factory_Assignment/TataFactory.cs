using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Assignment
{
    class TataFactory : VehicleFactory
    {
        LED led;
        Helogan helogen;
        public override CarLight CreateProduct1()
        {
            led= new LED();
            return led;
        }

        public override CarEngine CreateProduct2()
        {
            helogen= new Helogan();
            return helogen;
        }
    }
}
