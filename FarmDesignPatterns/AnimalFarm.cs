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

        public void SortAnimals()
        {
            int n = animals.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (animals[j].GetType().Name.CompareTo(animals[j + 1].GetType().Name) > 0)
                    {
                        
                        IAnimal temp = animals[j];
                        animals[j] = animals[j + 1];
                        animals[j + 1] = temp;
                    }
                }
            }
        }

    }
}
