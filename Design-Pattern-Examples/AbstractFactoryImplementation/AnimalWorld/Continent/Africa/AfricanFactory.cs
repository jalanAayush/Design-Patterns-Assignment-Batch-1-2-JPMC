using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation
{
    internal class AfricanFactory : ContinentFactory
    {
        public AfricanFactory()
        {
            Console.WriteLine("In African Continent Food herarchy is");
        }
        public override Herbivore CreateHerbivore()
        {
            return new Rabbit();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    
    }
}
