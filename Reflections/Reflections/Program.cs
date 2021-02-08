using System;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            var mbr = new MasterBedroom() { Length = 10, Width = 12 };
            var br = new Bedroom() { Length = 14, Width = 8 };

            //Reflections
            //Console.WriteLine(mbr.GetType().ToString());
            //Console.WriteLine(typeof(MasterBedroom).ToString());

            //IsSubClassOf() - Allows you to determine whether a class inherits
            //from a parent (or grandparent) class.

            //true
            //Console.WriteLine(typeof(Kitchen).IsSubclassOf(typeof(Room)));
            //Console.WriteLine(typeof(MasterBedroom).IsSubclassOf(typeof(Bedroom)));
            //Console.WriteLine(typeof(MasterBedroom).IsSubclassOf(typeof(Room)));

            //false
            //Console.WriteLine(typeof(MasterBedroom).IsSubclassOf(typeof(Kitchen)));
            //Console.WriteLine(mbr.GetType().IsSubclassOf(typeof(Kitchen)));


            //IsInstanceOfType() - Same idea, but allows you to work with instances of classes

            //Console.WriteLine(typeof(MasterBedroom).IsInstanceOfType(mbr)); //true

            //Console.WriteLine(typeof(Bedroom).IsInstanceOfType(mbr)); //true 
            //Console.WriteLine(typeof(Kitchen).IsInstanceOfType(mbr)); // false


            //IsAssignableFrom() - Determines whether an instance of a specified type can be
            //assigned to an instance of the current type

            //Console.WriteLine(typeof(MasterBedroom).IsAssignableFrom(typeof(Bedroom))); //false
            //Console.WriteLine(typeof(Bedroom).IsAssignableFrom(typeof(MasterBedroom))); //true
        }
    }

    class Room
    {
        public int Width { get; set; }
        public int Length { get; set; }
    }

    class Kitchen : Room
    {

    }

    class Bedroom : Room
    {

    }

    class MasterBedroom : Bedroom
    {

    }


}
