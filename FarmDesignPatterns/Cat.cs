using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDesignPatterns
{
    public class Cat:IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }

        public void GetHungry()
        {
            Console.WriteLine("\nCat is hungry!");
        }

        public bool ShouldGetHungry { get; } = true;
    }
}
