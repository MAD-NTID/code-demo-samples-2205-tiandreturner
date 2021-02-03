using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Automobile auto1 = new Automobile(2017, "Honda", "Civic", "Gold");
            //auto1.Make = "Honda";
            //auto1.Model = "Civic";
            //auto1.Year = 2017;
            //auto1.Color = "Gold";

            //New Car
            Car car1 = new Car(2019, "Chevrolet", "Volt", "Burgundy", 11.7);
            //car1.Make = "Chevrolet";
            //car1.Model = "Volt";
            //car1.Year = 2019;
            //car1.TrunkCapacity = 11.7;
            //car1.Color = "Burgundy";

            //New Truck
            Truck truck1 = new Truck(2021, "Ford", "F-150", "Black", 14000);
            //truck1.Make = "Ford";
            //truck1.Model = "F-150";
            //truck1.Year = 2021;
            //truck1.TowingCapacity = 14000;
            //truck1.Color = "Black";

            //Console.WriteLine(auto1.ToString());
            Console.WriteLine(car1.ToString());
            car1.Ignition();
            Console.WriteLine(truck1.ToString());
            truck1.Ignition();
        }
    }
}
