using System;
using System.Threading;

namespace MADBankThread
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(300);
            //Create array to store 15 threads and Izzy has no idea why I picked this number!
            //It will remain a mystery forever!!
            Thread[] threads = new Thread[15];

            Thread.CurrentThread.Name = "Main";

            //Create 15 threads that will call the IssueWithdraw method
            for(int i = 0; i < threads.Length; i++)
            {
                Thread t = new Thread(new ThreadStart(account.IssueWithdraw));
                t.Name = "Thread " + i;
                threads[i] = t;
            }

            //Let's get these threads to execute!
            for(int i = 0; i < threads.Length; i++)
            {
                Console.WriteLine($"Thread {threads[i].Name} Alive: {threads[i].IsAlive}");
                threads[i].Start();
                
                //threads[i].Join();
                //Let's double check and make sure thread has started
                Console.WriteLine($"Thread {threads[i].Name} Alive: {threads[i].IsAlive}");


            }

            //Get Thread Priority
            Console.WriteLine($"Current Priority: {Thread.CurrentThread.Priority}");

            Console.WriteLine($"{Thread.CurrentThread.Name} is ending.");
        }
    }
}
