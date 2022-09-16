using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Assignment
{
    internal class MarutiFactory:VehicleFactory
    {
        public DDIs ddis;
        public Revetron revetron;

        public override CarLight CreateProduct1()
        {
            ddis = new DDIs();
            return ddis;
        }

        public override CarEngine CreateProduct2()
        {
            revetron = new Revetron();
            return revetron;
        }
    }
}
