using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDesignPatterns
{
    public interface IAnimal
    {
        void MakeSound();
        void GetHungry();
        bool ShouldGetHungry { get; }
    }


}
