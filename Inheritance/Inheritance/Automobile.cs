using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    abstract class Automobile
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public Automobile(int year, string make, string model, string color)
        {
            Year = year;
            Make = make;
            Model = model;
            Color = color;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format($"\nYear: {Year.ToString()}\nMake: {Make}\n" +
                $"Model: {Model}\nColor: {Color}\n");
        }

        public abstract void Ignition();
    }
}
