using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDesignPatterns
{
    public class Chicken:IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Cluck!");
        }

        public void GetHungry()
        {
            Console.WriteLine("Chicken is hungry!");
        }

        public bool ShouldGetHungry { get; } = false;
    }
}
