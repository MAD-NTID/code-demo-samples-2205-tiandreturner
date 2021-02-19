using System;

namespace Delegates
{
    //Syntax for delegate
    //delegate <return type> <delegate-name> (<parameter list>)
    delegate void SecretMessage();
    delegate void PrintMessage(string s);
    class Program
    {
        static void Main(string[] args)
        {
            SecretMessage msg1 = new SecretMessage(SayHello);
            msg1();

            PrintMessage pm = new PrintMessage(PrintSomething);
            pm("Delegates are cool!");
        }

        static void SayHello()
        {
            Console.WriteLine("Hello World!");
        }

        static void PrintSomething(string s)
        {
            Console.WriteLine(s);
        }
    }
}
