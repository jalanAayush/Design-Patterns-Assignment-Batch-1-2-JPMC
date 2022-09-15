using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AnimalWorld.AfricaFactory
{
    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(GetType().Name + " eats " + h.GetType().Name);
        }
    }
}
