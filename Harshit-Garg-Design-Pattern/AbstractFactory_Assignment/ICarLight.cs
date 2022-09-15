using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Assignment
{
    internal interface ICarLight
    {
        public void checkCarLightStatus();
        public void addCarLight();

        public void removeCarLight();

        public void replaceCarLight();

    
    }
}
