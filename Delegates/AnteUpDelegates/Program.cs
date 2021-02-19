using System;

namespace AnteUpDelegates
{
    delegate int NumberChanger(int n);
    class Program
    {
        static int num = 10;
        static void Main(string[] args)
        {
            //create delegate instances
            //NumberChanger nc1 = new NumberChanger(AddNum);
            //NumberChanger nc2 = new NumberChanger(MultNum);

            NumberChanger ncMulti = new NumberChanger(AddNum);
            ncMulti += MultNum;

            //calling the methods using delegate objects
            //nc1(25);
            // Console.WriteLine($"Value of Num: {GetNum()}");

            //nc2(5);
            ncMulti(5);
            Console.WriteLine($"Value of Num: {GetNum()}");

        }

        static int AddNum(int p)
        {
            num += p;
            return num;
        }

        static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        static int GetNum()
        {
            return num;
        }
    }
}
