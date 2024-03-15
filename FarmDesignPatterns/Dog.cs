using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDesignPatterns
{
    public class Dog:IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

        public void GetHungry()
        {
            Console.WriteLine("Dog is hungry!");
        }

        public bool ShouldGetHungry { get; } = true;
    }
}
