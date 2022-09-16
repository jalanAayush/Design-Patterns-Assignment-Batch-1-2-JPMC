using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal interface ICarLight
    {
        public void CheckCarLightStatus();
        public void AddCarLight();

        public void RemoveCarLight();

        public void ReplaceCarLight();


    }
}