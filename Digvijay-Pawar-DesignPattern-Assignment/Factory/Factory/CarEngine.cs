using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface CarEngine
    {
        public void checkEngineStatus();
        public void replaceEngine();
        public void addEngine();

        public void removeEngine();

    }
}
