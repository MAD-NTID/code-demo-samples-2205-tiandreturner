using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CarDictionary
{
    enum Manufacturer
    {
        Ford,
        Chevrolet,
        Dodge,
        Nissan,
        Honda,
        Toyota
    }
    class Car
    {
        //Data Fields -- By default, they should be private!
        private int year;
        private string color;
        private double gasTankCapacity;
        private string carType;
        private string make;
        private string model;
        private bool isRunning;
        private string[] makes = { "Ford", "Chevrolet", "Dodge", "Honda", "Toyota", "Subaru", "Nissan" };

        private Engine engine;


        //type in 'propfull' to activate code snippet to create data field and property
        private int numDoors;

        public int NumDoors
        {
            get { return numDoors; }
            set {
                if (value == 2 || value == 4)
                    numDoors = value;
                else
                    numDoors = 0;
            }
        }


        //Properties
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value >= 1885 && value <= DateTime.Now.Year)
                    year = value;
                else
                    year = DateTime.Now.Year;
            }
        }
        public string Color { get; set; }
        public double GasTankCapacity { get
            {
                return gasTankCapacity;
            }
            set { 
                gasTankCapacity = value; 
            } 
        }
        public string CarType { get; set; }
        public string Make {
            get
            {
                return make;
            }
            set
            {
                foreach (string m in makes)
                {
                    if (value == m)
                    {
                        make = value;
                        return;
                    }
                }
                make = "Unidentified Make";
            }
        }
        public string Model { get; set; }
        public bool IsRunning { get; set; }
        public Engine Engine { get { return engine; } set { engine = value; } }

        public void Drive(int miles)
        {
            if(IsRunning)
            {
                Console.WriteLine($"Car is now in drive mode. You can drive for approximately {miles} miles.");
            }
            else
            {
                Console.WriteLine("Cannot shift into drive mode, car is not running");
            }
        }

        //Default Constructor
        public Car()
        {
            Year = 1900;
            Make = "Unknown";
            Model = "Unknown";
            GasTankCapacity = 0;
            CarType = "N/A";
            Color = "Black";
            IsRunning = false;
            Engine = null;
        }

        //Parameterized Constructor
        public Car(int year, string color, int gasTankCapacity, string make, string model, string carType, Engine engine)
        {
            Year = year;
            Color = color;
            GasTankCapacity = gasTankCapacity;
            Make = make;
            Model = model;
            CarType = carType;
            IsRunning = true;
            Engine = engine;
        }

        
        public override string ToString()
        {
            return String.Format($"Year: {Year}\nMake: {Make}\nModel: {Model}\n" +
                $"Car Type: {CarType}\nColor: {Color}\n" +
                $"Gas Tank Capacity: {GasTankCapacity}\nNumber of Doors: {NumDoors}\nEngine: {Engine}");
        }
    }
}
