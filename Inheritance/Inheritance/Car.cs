using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Car : Automobile
    {
        public double TrunkCapacity { get; set; }

        public Car(int year, string make, string model, string color, double trunkCapacity) : base(year, make, model, color)
        {
            TrunkCapacity = trunkCapacity;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format($"Trunk Capacity: {TrunkCapacity}");
        }
    }
}
