using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface CarLight
    {
        public void checkLightStatus();
        public void addLight();

        public void removeLight();

        public void replaceLight();

    }
}
