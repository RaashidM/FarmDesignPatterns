using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmDesignPatterns
{
    public class Farm
    {
        private static Farm instance;

        private Farm() { }

        public static Farm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Farm();
                }

                return instance;
            }
        }

        public void Greeting()
        {
            Console.WriteLine("Welcome to the farm!");
        }
    }
}
