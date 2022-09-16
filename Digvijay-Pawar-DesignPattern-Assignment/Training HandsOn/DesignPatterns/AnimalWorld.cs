using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class AnimalWorld
    {
        private Herbivores herbivores;
        private Carnivores carnivores;

        public AnimalWorld(ContinentFacotry factory)
        {
            carnivores = factory.CreateCarnivore();
            herbivores = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            carnivores.Eat(herbivores);
        }
    }
}
