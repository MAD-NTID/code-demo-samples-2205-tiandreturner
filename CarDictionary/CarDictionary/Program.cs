using System;
using System.Collections.Generic;
using System.IO;

namespace CarDictionary
{
    class Program
    {
        static List<Engine> engineList = new List<Engine>();
        static Dictionary<string, Car> carDict = new Dictionary<string, Car>();
        static string carDataFile = "carRecords.bpt";
        static string engineDataFile = "engines.tjt";
        static void Main(string[] args)
        {
            
            string menu = String.Format($"1. Build a car\n2. Add an engine\n3. Remove a car\n" +
                $"4. List all cars\n5. List all engines\n6. Search for car\n7. Remove car from list (sold)\n8. Search for car (sold)\n9. Exit\n\nEnter your option: ");

            //List<Car> carList = new List<Car>();
            
            Dictionary<string, Car> soldDict = new Dictionary<string, Car>();

            ////Build engines -- code uses OIS (Object Initializer Syntax), a cool feature of C#.  Sorry Java!
            //engineList.Add(new Engine() { EngineSize = 2.0, FuelType = "Gas", HorsePower = 180, NumCylinders = 4 });
            //engineList.Add(new Engine() { EngineSize = 3.5, FuelType = "Gas", HorsePower = 290, NumCylinders = 6 });
            //engineList.Add(new Engine() { EngineSize = 6.7, FuelType = "Diesel", HorsePower = 440, NumCylinders = 8 });

            ////Build cars
            //carDict.Add("1000FB", new Car() { CarType = "sedan", Color = "green", Year = 2014, Make = "Ford", Model = "Focus", GasTankCapacity = 14, NumDoors = 4, Engine = engineList[0] });
            //carDict.Add("2020CV", new Car() { CarType = "sedan", Color = "red", Year = 2012, Make = "Ford", Model = "Fusion", GasTankCapacity = 18, NumDoors = 4, Engine = engineList[1] });
            //carDict.Add("2050FD", new Car() { CarType = "truck", Color = "black", Year = 2017, Make = "Ford", Model = "F-250", GasTankCapacity = 34, NumDoors = 4, Engine = engineList[2] });

            //Load data
            LoadCarData();
            LoadEngineData();

            while (true)
            {
                Console.Write(menu);

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1: //Build a car
                        NewCarData();
                        break;

                    case 2: //Add an engine
                        NewEngineData();
                        break;
                    case 3: //Remove a car
                        RemoveCarData();
                        break;

                    case 4: //List all cars
                        ListCarData();
                        break;

                    case 5: //List all engines
                        DisplayEngines();
                        break;

                    case 6: //Does it have a key specified by the user?
                        SearchByKey();
                        break;

                    case 7:
                        Console.Write("Specify the car that was sold: ");
                        string transferKey = Console.ReadLine();
                        if (carDict.Remove(transferKey, out Car car))
                            soldDict.Add(transferKey, car);
                        else
                            Console.WriteLine($"Cannot perform operation: The stock number {transferKey} does not exist in the list.");
                        Console.WriteLine();
                        break;

                    case 8: //Does it have a key specified by the user?
                        Console.Write("Specify the key to search: ");
                        string soldKey = Console.ReadLine();
                        if (soldDict.ContainsKey(soldKey))
                            Console.WriteLine(soldDict[soldKey]);
                        else
                            Console.WriteLine($"The stock number {soldKey} does not exist.");
                        Console.WriteLine();
                        break;

                    case 9: //Exit the program - so easy a cave man can do this!  Sponsored by GEICO
                        SaveCarData();
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        continue;
                }
            }
        }//end Main

        private static void LoadEngineData()
        {
            using (StreamReader sr = new StreamReader(engineDataFile))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] carInfo = line.Split("|");
                    engineList.Add(new Engine()
                    {
                        EngineSize = double.Parse(carInfo[0]),
                        NumCylinders = int.Parse(carInfo[1]),
                        FuelType = carInfo[2],
                        HorsePower = int.Parse(carInfo[3]),
                    });
                }
            }
        }

        private static void SearchByKey()
        {
            Console.Write("Specify the key to search: ");
            string key = Console.ReadLine().ToUpper();
            if (carDict.ContainsKey(key))
                Console.WriteLine(carDict[key]);
            else
                Console.WriteLine($"The stock number {key} does not exist.");
            Console.WriteLine();
        }

        private static void ListCarData()
        {
            int i = 1;

            foreach (KeyValuePair<string, Car> kvp in carDict)
            {
                Console.WriteLine($"============Car Stock# {kvp.Key}==============");
                Console.WriteLine(kvp.Value);
                Console.WriteLine("");
                i++;
            }
            Console.WriteLine("\n");
        }

        private static void RemoveCarData()
        {
            Console.Write($"Enter the stock number to remove a car: ");
            string sn = Console.ReadLine();
            if (carDict.Remove(sn))
                Console.WriteLine($"Car with stock number {sn} removed");
            else
                Console.WriteLine($"Car with stock number {sn} does not exist");
        }

        private static void NewEngineData()
        {
            Console.Write("Number of cylinders: ");
            int nc = int.Parse(Console.ReadLine());
            Console.Write("Fuel type: ");
            string ft = Console.ReadLine();
            Console.Write("Horsepower: ");
            int hp = int.Parse(Console.ReadLine());
            Console.Write("Engine size (L): ");
            double engSize = double.Parse(Console.ReadLine());
            engineList.Add(new Engine() { EngineSize = engSize, FuelType = ft, HorsePower = hp, NumCylinders = nc });
            SaveEngineData();
        }

        private static void SaveEngineData()
        {
            using (StreamWriter sw = new StreamWriter(engineDataFile))
            {
                foreach (Engine e in engineList)
                {
                    //6.7|8|diesel|470
                    sw.WriteLine($"{e.EngineSize}|{e.NumCylinders}|{e.FuelType}|" +
                        $"{e.HorsePower}");
                }
            }
        }

        private static void NewCarData()
        {
            Console.Write("Enter the stock number: ");
            string stockNum = Console.ReadLine().ToUpper();
            Console.Write("Enter the year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter the color of the car: ");
            string color = Console.ReadLine();
            Console.Write("Enter the car type: ");
            string carType = Console.ReadLine();
            Console.Write("Enter the make of the car: ");
            string make = Console.ReadLine();
            Console.Write("Enter the model of the car: ");
            string model = Console.ReadLine();
            Console.Write("Enter the gas tank capacity: ");
            int gtc = int.Parse(Console.ReadLine());
            Engine selectedEngine = null;

            if (engineList.Count > 0)
            {
                Console.Write("Select your engine: ");

                DisplayEngines();
                Console.Write("\nChoose your engine: ");
                selectedEngine = engineList[int.Parse(Console.ReadLine()) - 1];
            }
            carDict.Add(stockNum, new Car(year, color, gtc, make, model, carType, selectedEngine));
            SaveCarData();
        }

        private static void SaveCarData()
        {
            using(StreamWriter sw = new StreamWriter(carDataFile))
            {
                foreach(KeyValuePair<string, Car> kvp in carDict)
                {
                    sw.WriteLine($"{kvp.Key},{kvp.Value.Year},{kvp.Value.Make}," +
                        $"{kvp.Value.Model},{kvp.Value.CarType},{kvp.Value.Color}," +
                        $"{kvp.Value.GasTankCapacity},{kvp.Value.NumDoors}," +
                        $"{kvp.Value.Engine.EngineSize},{kvp.Value.Engine.NumCylinders}," +
                        $"{kvp.Value.Engine.FuelType},{kvp.Value.Engine.HorsePower}");
                }
            }
        }

        private static void LoadCarData()
        {
            using (StreamReader sr = new StreamReader(carDataFile))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] carInfo = line.Split(",");
                    carDict.Add(carInfo[0], new Car() { Year = int.Parse(carInfo[1]), 
                        Make = carInfo[2], Model = carInfo[3], CarType = carInfo[4], 
                        Color = carInfo[5], GasTankCapacity = int.Parse(carInfo[6]), 
                        NumDoors = int.Parse(carInfo[7]), 
                        Engine = new Engine() { EngineSize = double.Parse(carInfo[8]), 
                            NumCylinders = int.Parse(carInfo[9]), FuelType = carInfo[10], 
                            HorsePower = int.Parse(carInfo[11]) } });

                    /*engineList.Add(new Engine() { EngineSize = double.Parse(carInfo[8]), 
                        FuelType = carInfo[10], HorsePower = int.Parse(carInfo[11]), 
                        NumCylinders = int.Parse(carInfo[9]) });*/
                }
            }

                
        }

        public static void DisplayEngines()
        {
            int j = 1;
            foreach (Engine e in engineList)
            {
                Console.WriteLine($"{j}. {e}");
                j++;
            }
            Console.WriteLine();
        }
    }
}
