using System;
using System.Collections.Generic;
using System.Text;

namespace MyTools
{
    public static class MyAwesomeToolbox
    {
        public static void PrettyPrint(string message, ConsoleColor color, int newLines)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            for (int i = 0; i < newLines; i++)
                Console.WriteLine();
            Console.ResetColor();
        }

        public static int ProduceLuckyNumber()
        {
            Random random = new Random();
            return random.Next();
        }
    }
}
