using System;
using MyTools;
using ExtensionToolBox;

namespace StaticFromRubbingCarpet
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Extension methods are wicked cool!";
            MyAwesomeToolbox.PrettyPrint("Static is very cool!", ConsoleColor.Cyan, 2);
            MyAwesomeToolbox.PrettyPrint("Static can be fun after rubbing carpet! :)", ConsoleColor.Yellow, 1);
            MyAwesomeToolbox.PrettyPrint(MyAwesomeToolbox.ProduceLuckyNumber().ToString(), ConsoleColor.Green, 4);

            Automobile auto = new Automobile();
            auto.Drive();
            auto.DriveElectric();
        }
    }

    sealed class Automobile
    {
        public void Drive()
        {
            Console.WriteLine("Automobile is driving");
        }
    }

    static class AutomobileExtensions
    {
        public static void DriveElectric(this Automobile auto)
        {
            Console.WriteLine("Electric car is driving");
        }
    }
}
