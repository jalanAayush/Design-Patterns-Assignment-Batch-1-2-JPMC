using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AnimalWorld.AfricaFactory
{
    class AfricaFactory : ContinentFactory
    {
        public AfricaFactory()
        {
            Console.WriteLine("In Africa Food herarchy is");
        }
        public override Herbivore CreateHerbivore()
        {
            return new Cat();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

    }
}
