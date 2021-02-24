using System;
using System.Collections.Generic;

namespace FuncActionDelegates
{
    
    class Program
    {
        public static Action<int, int> DrawLuckyNumber;
        public static Func<int, int> DrawLuckyMaxNumber;
        public static Func<List<int>, int> PickANumber;
        public delegate int MyLuckyNumber(int x);
        static void Main(string[] args)
        {
            //DrawLuckyNumber = delegate (int x, int y)
            //{
            //    Random rand = new Random();
            //    Console.WriteLine(rand.Next(x, y));
            //};
            List<int> numbers = new List<int> { 4, 8, 15, 16, 23, 42 };
            Random rand = new Random();

            DrawLuckyNumber = (x, y) => Console.WriteLine(rand.Next(x, y));

            DrawLuckyMaxNumber = (x) => { return rand.Next(x); };

            PickANumber = (x) => { return x[rand.Next(x.Count - 1)]; };
   
            MyLuckyNumber luckyNumber = (x) => { return rand.Next(x); };

            DrawLuckyNumber(25, 75);
            DrawLuckyNumber(-50, 225);
            DrawLuckyNumber(0, 1000);
            DrawLuckyNumber(15, 500);

            Console.WriteLine(DrawLuckyMaxNumber(75));
            Console.WriteLine(DrawLuckyMaxNumber(225));
            Console.WriteLine(DrawLuckyMaxNumber(1000));
            Console.WriteLine(DrawLuckyMaxNumber(500));

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(PickANumber(numbers));
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(luckyNumber(int.MaxValue));
            Console.ResetColor();
        }
    }
}
