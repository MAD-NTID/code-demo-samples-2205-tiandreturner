using System;
using System.Threading;


namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action<object> action = PrintJob1;
            //ParameterizedThreadStart pts = PrintJob1;
            //action(100);
            Thread t = new Thread(PrintJob1);
            Thread t2 = new Thread(PrintJob2);
            t.Start(1000);
            t2.Start(700);

            Thread.Sleep(100);

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(1);
            }
        }

        static void PrintJob1(object value)
        {
            int max = (int)value;
            for (int i = 0; i < max; i++)
            {
                Console.Write(0);
            }
            
        }

        static void PrintJob2(object value)
        {
            int max = (int)value;
            for (int i = 0; i < max; i++)
            {
                Console.Write(2);
            }
        }
        //static void PrintJob1()
        //{
        //    for(int i =0; i < 1000; i++)
        //    {
        //        Console.Write(0);
        //    }
        //}


    }
}
