using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Bear : IAnimal
    {
        public string Type { get; set; }
        public void AnimalSound()
        {
            Console.WriteLine("ROAR!!!");
        }

        public void Run()
        {
            Console.WriteLine("I run faster than humans so YOU will be EATEN.  Yummy!");
        }

        public void Eat(IAnimal animal)
        {
            Console.WriteLine($"Bear devours {animal.GetType()}");
        }
    }
}
