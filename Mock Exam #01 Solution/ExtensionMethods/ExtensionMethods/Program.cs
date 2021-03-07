using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello World!";
            message.PrintColorfulLine(ConsoleColor.Yellow);
            Console.WriteLine(message.CountSpecificLetter('o'));
            message.Reverse().PrintColorfulLine(ConsoleColor.Cyan);
        }
    }

    static class StringExtensions
    {
        public static void PrintColorfulLine(this string s, ConsoleColor c)
        {
            Console.ForegroundColor = c;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        public static int CountSpecificLetter(this string s, char c)
        {
            int count = 0;
            foreach(char ch in s)
            {
                if (ch == c)
                    count++;
            }

            return count;
        }

        public static string Reverse(this string s)
        {
            string newString = "";
            for(int i = s.Length - 1; i >= 0; i--)
            {
                newString += s[i];
            }
            return newString;
        }
        
    }
}
