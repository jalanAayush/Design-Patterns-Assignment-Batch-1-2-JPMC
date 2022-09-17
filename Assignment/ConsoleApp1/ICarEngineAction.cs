using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Assignment
{
    public interface ICarEngineAction
    {
        public void checkCarEngineStatus();
        public void addCarEngine();

        public void remCarEngine();

        public void replaceCarEngine();


    }
}
