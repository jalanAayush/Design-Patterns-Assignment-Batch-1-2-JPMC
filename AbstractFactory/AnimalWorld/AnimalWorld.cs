﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            Console.WriteLine("Welcome to Animal World");

            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
