using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryImplementation
{
    class AnimalWorldcs
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;


        //Abstract Factory Pattern
        public AnimalWorldcs(ContinentFactory factory)
        {
            Console.WriteLine("Welcome to Animal World");

            _herbivore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
