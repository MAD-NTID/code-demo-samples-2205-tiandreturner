using System;
using MyTools;
using ExtensionToolBox;

namespace ExtensionMethods
{
    public static class Extensions
    {
        static void Main()
        {
            string s = "Hello Extension Methods";
            int i = s.WordCount();
            MyAwesomeToolbox.PrettyPrint($"Is it more than 100 words? : {i.IsGreaterThan100()}", ConsoleColor.Cyan, 2);
            MyAwesomeToolbox.PrettyPrint(i.ToString(), ConsoleColor.Magenta, 1);
        }
    }
}
