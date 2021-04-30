using System;
using System.Threading;

namespace ThreadLock
{
    class Program
    {
        static void Main(string[] args)
        {
            SharedData sharedData = new SharedData();
            Thread t1 = new Thread(sharedData.Increment);
            t1.Start();
            sharedData.Increment();
            t1.Join();
            Console.WriteLine(sharedData.Number);
        }
    }

    class SharedData
    {
        public int Number;
        private object numberLock = 1;

        public void Increment()
        {
            lock (numberLock)
            {
                Number++;
            }
        }
    }
}
