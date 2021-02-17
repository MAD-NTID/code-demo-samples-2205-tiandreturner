using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionToolBox
{
    static class MyExtensionMethods
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
            StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static bool IsGreaterThan100(this int i)
        {
            if (i > 100)
                return true;
            return false;
        }
    }
}
