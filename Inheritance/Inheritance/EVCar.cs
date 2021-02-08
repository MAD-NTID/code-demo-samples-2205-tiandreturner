using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class EVCar : Car
    {
        public EVCar(int year, string make, string model, string color, double trunkCapacity, string vin) : base(year, make, model, color, trunkCapacity, vin)
        {

        }

        public override string ToString()
        {
            return String.Format("EV Car\n") + base.ToString();
        }
    }
}
