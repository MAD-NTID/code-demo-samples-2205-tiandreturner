using System;
using System.IO;

namespace FilesAndArrays
{
    class Program
    {
        static int[] temperatures = new int[12];
        static void Main(string[] args)
        {
            while (true)
            {
                ReadFile();

                int total = 0;
                foreach (int t in temperatures)
                {
                    total += t;
                }

                Console.WriteLine($"The average temperature for the year in Rochester, NY is {total / temperatures.Length}");

                Console.Write("Does the file needs to be updated? (y/n): ");

                if (Console.ReadLine().ToLower() == "y")
                {
                    UpdateTemperature();
                    WriteFile();
                    Console.WriteLine("File has been updated");
                }
                else
                    break;
            }//end outer loop

        }//end Main

        public static void ReadFile()
        {
            string line = null;
            int counter = 0;
            //try
            //{
                using (StreamReader reader = new StreamReader("temperatures.txt"))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        temperatures[counter] = int.Parse(line);
                        counter++;
                    }
                }
            //}
            //catch(FileNotFoundException fnfe)
            //{
            //    Console.WriteLine(fnfe.Message);
            //    Console.WriteLine("File not found.  Are you sure the file is there?");
            //    Environment.Exit(0);
            //}
            //catch(FormatException fe)
            //{
            //    Console.WriteLine(fe.Message);
            //    Console.WriteLine("It appears that data is not formatted correctly.  Check the file and make sure it contains only numbers.");
            //    Environment.Exit(0);
            //}
            //catch(Exception e)
            //{

            //}
        }

        public static void WriteFile()
        {
            using (StreamWriter writer = new StreamWriter("temperatures.txt"))
            {
                foreach(int t in temperatures)
                {
                    writer.WriteLine(t); //write a number each line
                }
            }
        }

        public static void UpdateTemperature()
        {
            for (int i = 0; i < temperatures.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {temperatures[i]}");
            }

            Console.Write("\nWhich temperature would you like to change? ");
            int index = int.Parse(Console.ReadLine());

            Console.Write("Enter the new temperature value: ");
            int newTemperature = int.Parse(Console.ReadLine());

            temperatures[index - 1] = newTemperature;
        }
    }
}
