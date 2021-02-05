using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //You cannot instantiate an interface  -- YOU READ IT HERE FIRST!
            //IAnimal animal = new IAnimal();

            //In case you forget, this is actually solid code!  Thumbs up!
            //Pig myPig = new Pig();
            //myPig.AnimalSound();
            //myPig.Run();

            //IAnimal bear = new Bear();
            //bear.AnimalSound();
            //bear.Run();

            //IAnimal pig = new Pig();
            //pig.AnimalSound();
            //pig.Run();

            //Cannot instantiate an interface  -- You would THINK you'd learn by NOW
            //Pig myPig = new IAnimal();

            //This hopefully won't explode brains!

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(new Pig() { Type = "Wild Boar" });
            animals.Add(new Bear() { Type = "Grizzly Bear" });
            animals.Add(new Pig() { Type = "Berkshire" });

            foreach(IAnimal animal in animals)
            {
                if(animal is Pig)
                {
                    Pig pig = animal as Pig;
                    Console.WriteLine(pig.Type);
                    pig.AnimalSound();
                    pig.Run();
                }
                if (animal is Bear)
                {
                    Bear bear = animal as Bear;
                    Console.WriteLine(bear.Type);
                    bear.AnimalSound();
                    bear.Run();
                    bear.Eat(new Pig());
                }
            }

        }
    }
}
