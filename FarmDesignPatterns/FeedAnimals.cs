using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDesignPatterns
{
    public class FeedAnimals : ICommand
    {
        private readonly AnimalFarm animalFarm;

        public FeedAnimals(AnimalFarm animalFarm)
        {
            this.animalFarm = animalFarm;
        }

        public void Execute()
        {
            animalFarm.FeedAnimals();
        }
    }
}
