using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_a
    {
    class MainApp
        {
        public static void Main()
            {
            IVehicleFactory maruti = new MarutiFactory();
            Client userM = new Client(maruti);
            userM.CarAccessoriesBusiness();


            IVehicleFactory tata = new TataFactory();
            Client userT = new Client(tata);
            userT.CarAccessoriesBusiness();
            }
        }
    }
