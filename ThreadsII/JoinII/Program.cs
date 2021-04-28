using System;
using System.Threading;

namespace JoinII
{
    class Program
    {
        static void Main(string[] args)
        {
            JoinDemo obj = new JoinDemo();
            Thread thread1 = new Thread(new ThreadStart(obj.Display));
            thread1.Name = "Thread 1";
            Thread thread2 = new Thread(new ThreadStart(obj.Display));
            thread2.Name = "Thread 2";
            Thread thread3 = new Thread(new ThreadStart(obj.Display));
            thread3.Name = "Thread 3";

            //start thread 1
            thread1.Start();
            thread1.Join();
            //start thread 2
            thread2.Start();
            thread2.Join(150);
            //start thread 3
            thread3.Start();
            thread3.Join();

            //calling Join() on thread1 2 and 3
            //thread1.Join();
            //thread2.Join(3000);
            //if(thread3.Join(2000))
            //{
            //    Console.WriteLine("Execution of thread3 completed in 2 seconds");
            //}
            //else
            //{
            //    Console.WriteLine("Execution of thread3 not completed in 2 seconds");
            //}

            Console.WriteLine("Main Thread Done!");
        }

        
    }

    class JoinDemo
    {
        public void Display()
        {
            for(int i = 0; i <= 50; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " " + i);
                Thread.Sleep(1);
            }
        }
    }
}
