using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Car : Automobile
    {
        public double TrunkCapacity { get; set; }

        public Car(int year, string make, string model, string color, double trunkCapacity, string vin) : base(year, make, model, color)
        {
            TrunkCapacity = trunkCapacity;
            base.vin = vin;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format($"Trunk Capacity: {TrunkCapacity}\n");
        }

        public sealed override void Ignition()
        {
            Console.WriteLine("Engine running");
        }
    }
}
