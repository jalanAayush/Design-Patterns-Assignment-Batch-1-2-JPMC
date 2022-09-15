using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation
{
     class AmericanFactory : ContinentFactory
    {
        public AmericanFactory()
        {
            Console.WriteLine("In American Continent Food herarchy is");
        }
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
