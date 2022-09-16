using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface ICarEngine
    {
        public void CheckCarEngineStatus();
        public void AddCarEngine();

        public void RemoveCarEngine();

        public void ReplaceCarEngine();
    }
}
