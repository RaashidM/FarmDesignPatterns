using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDesignPatterns
{
    public class AnimalFarm
    {
        private List<IAnimal> animals = new List<IAnimal>();

        public void AddAnimal(IAnimal animal)
        {
            animals.Add(animal);
        }

        public void BubbleSortAnimalsByName()
        {
            animals = animals.OrderBy(a => a.GetType().Name).ToList();
        }

        public void MakeSoundsOfAnimals()
        {
            foreach (var animal in animals)
            {
                string animalType = animal.GetType().Name; 
                Console.Write($"{animalType} says: ");
                animal.MakeSound(); 
            }
        }

        public IAnimal GetAnimal(string type)
        {
            return animals.FirstOrDefault(a => a.GetType().Name == type);
        }


        public void GetHungry()
        {
            foreach (var animal in animals)
            {
                if (animal.ShouldGetHungry)
                {
                    animal.GetHungry();
                }
            }
        }

        public void FeedAnimals()
        {
            Console.WriteLine("\nFeeding the animals...");
            Console.WriteLine("The animals have been fed.");
        }
    }
}
