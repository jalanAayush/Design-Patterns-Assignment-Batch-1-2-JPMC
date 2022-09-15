using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AnimalWorld.AmericaFactory
{
    class AmericaFactory : ContinentFactory
    {

        public AmericaFactory()
        {
            Console.WriteLine("In America Food herarchy is");
        }
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}
