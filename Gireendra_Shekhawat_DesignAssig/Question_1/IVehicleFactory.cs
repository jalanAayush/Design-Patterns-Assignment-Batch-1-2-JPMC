using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_a
    {
    interface IVehicleFactory
        {
        //public abstract 
        ICarEngine CreateCarEngine();
        ICarLight CreateCarLight();

        }
    }
