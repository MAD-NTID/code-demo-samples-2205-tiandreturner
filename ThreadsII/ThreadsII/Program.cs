using System;
using System.Threading;

namespace ThreadsII
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(() =>
            {
                CountTo(5, ConsoleColor.Cyan);
                CountTo(6, ConsoleColor.Magenta);
            });
            t.Start();

            //new Thread(() =>
            //    CountTo(6, ConsoleColor.Magenta)
            //).Start();

            Console.ResetColor();
        }

        static void CountTo(int max, ConsoleColor color)
        {
            
            for(int i = 0; i <= max; i++)
            {
                Console.ForegroundColor = color;
                Console.Write(i);
            }
        }
    }
}
