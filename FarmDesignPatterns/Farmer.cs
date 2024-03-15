using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDesignPatterns
{
    public class Farmer:IObserver
    {
        private string name;
        private List<IAnimal> subscribedAnimals = new List<IAnimal>();

        public Farmer(string name)
        {
            this.name = name;
        }

        public void Subscribe(IAnimal animal)
        {
            subscribedAnimals.Add(animal);
        }

        public void Unsubscribe(IAnimal animal)
        {
            subscribedAnimals.Remove(animal);
        }

        public void Update()
        {
            foreach (var animal in subscribedAnimals)
            {
                if (animal.ShouldGetHungry)
                {
                    Console.WriteLine($"\n{name} received message: Time to feed {animal.GetType().Name}");
                }
            }
        }
    }
}
