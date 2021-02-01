using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Truck : Automobile
    {
        public int TowingCapacity { get; set; }

        public Truck(int year, string make, string model, string color, int towCapacity) : base(year, make, model, color)
        {
            TowingCapacity = towCapacity;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format($"Tow Capacity: {TowingCapacity}");
        }
    }
}
