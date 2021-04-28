using System;
using System.Threading;

namespace Join
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread0 = new Thread(CountTo100);
            thread0.Start();
            thread0.Join();  //make sure to join first before starting another thread for synchronous processing 

            Thread thread1 = new Thread(CountTo101);
            thread1.Start();
            
            thread1.Join();

            Console.WriteLine("Main Thread Done");
        }

        static void CountTo100()
        {

            for (int i = 0; i <= 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(i);
            }
        }

        static void CountTo101()
        {

            for (int i = 0; i <= 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(i);
            }
        }
    }
}
