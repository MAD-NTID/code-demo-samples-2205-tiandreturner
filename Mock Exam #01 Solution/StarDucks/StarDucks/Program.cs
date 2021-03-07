using System;
using System.Collections.Generic;

namespace StarDucks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Coffee> coffees = new List<Coffee>();

            while (true)
            {
                Coffee coffee = new Coffee();
                //Prompt for size
                Console.WriteLine("What size coffee would you like:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                int i = 1;
                foreach (CoffeeSize cs in Enum.GetValues(typeof(CoffeeSize)))
                {
                    Console.WriteLine($"\t{i}. {cs.ToString()}");
                    i++;
                }
                Console.ResetColor();
                Console.Write("Enter your option: ");
                coffee.Size = ((CoffeeSize)int.Parse(Console.ReadLine()) - 1);

                //Prompt for flavors
                i = 1;
                Console.WriteLine("What flavor coffee would you like:");
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (Flavors f in Enum.GetValues(typeof(Flavors)))
                {
                    Console.WriteLine($"\t{i}. {f.ToString()}");
                    i++;
                }
                Console.ResetColor();
                Console.Write("Enter your option: ");
                int selection = (int.Parse(Console.ReadLine()) - 1);
                if (selection != 1)
                    coffee.coffeePreparer += coffee.AddFlavor;
                coffee.Flavor = ((Flavors)selection);

                Console.Write("Would you like sugar in your coffee? (y/n): ");
                switch(Console.ReadLine())
                {
                    case "y": coffee.HasSugar = true;
                        coffee.coffeePreparer += coffee.AddSugar;
                        break;
                    case "n": coffee.HasSugar = false;
                        break;
                }

                Console.Write("Would you like cream in your coffee? (y/n): ");
                switch (Console.ReadLine())
                {
                    case "y":
                        coffee.HasCream = true;
                        coffee.coffeePreparer += coffee.AddCream;
                        break;
                    case "n":
                        coffee.HasCream = false;
                        break;
                }

                coffees.Add(coffee);
                Console.Write("Would you like to add another coffee order? (y/n): ");
                if (Console.ReadLine() != "y")
                    break;
            }

            int coffeeQueueNumber = 1;
            //Prepare order
            foreach(Coffee c in coffees)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Coffee #{coffeeQueueNumber}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                c.coffeePreparer();
            }
            Console.ResetColor();
        }
    }

    enum CoffeeSize
    {
        Small,
        Medium,
        Large
    }

    enum Flavors
    {
        Plain,
        Hazelnut,
        Mocha,
        Caramel,
        Vanilla
    }
    class Coffee
    {
        public delegate void CoffeePreparer();

        public CoffeePreparer coffeePreparer = null;
        public CoffeeSize Size { get; set; }
        public bool HasSugar { get; set; }
        public bool HasCream { get; set; }
        public Flavors Flavor { get; set; }

        public Coffee()
        {
            coffeePreparer = PourCoffee;
        }

        public void PourCoffee()
        {
            Console.WriteLine($"Pour coffee in {this.Size} cup");
        }
        public void AddFlavor()
        {
            Console.WriteLine($"Add flavor: {this.Flavor}");
        }

        public void AddSugar()
        {
            Console.WriteLine("Add sugar");
        }

        public void AddCream()
        {
            Console.WriteLine("Add cream");
        }
    }

}
