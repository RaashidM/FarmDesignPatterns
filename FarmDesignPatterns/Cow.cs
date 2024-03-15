using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDesignPatterns
{
    public class Cow:IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Moo!");
        }

        public void GetHungry()
        {
            Console.WriteLine("Cow is hungry!");

        }     
        public bool ShouldGetHungry { get; } = true;
    }
}
