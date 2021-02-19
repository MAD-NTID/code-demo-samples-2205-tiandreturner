using System;
using System.IO;

namespace FileIODelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintString.PrintSomething ps1 = new PrintString.PrintSomething(PrintString.WriteToScreen);
            //PrintString.PrintSomething ps2 = new PrintString.PrintSomething(PrintString.WriteToFile);
            ps1 += PrintString.WriteToFile;


            PrintString.SendString(ps1);
            //PrintString.SendString(ps2);
        }
    }

    class PrintString
    {
        static FileStream fs;
        static StreamWriter sw;

        //delegate declaration
        public delegate void PrintSomething(string s);

        public static void WriteToScreen(string str)
        {
            Console.WriteLine($"The string is {str}");
        }

        public static void WriteToFile(string s)
        {
            fs = new FileStream("message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public static void SendString(PrintSomething ps)
        {
            //add code that invokes delegate object
            ps("Total awesomeness that you will never forget");
        }
    }
}
