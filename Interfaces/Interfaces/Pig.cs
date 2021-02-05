using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Pig :IAnimal
    {
        public string Type { get; set; }
        public void AnimalSound()
        {
            Console.WriteLine("Oink oink");
        }

        public void Run()
        {
            Console.WriteLine("I don't run, I jog");
        }
    }
}
