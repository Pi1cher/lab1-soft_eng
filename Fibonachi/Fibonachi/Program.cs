using System;
using System.Collections.Generic;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateFibonachi(5));
            Console.WriteLine(CalculateFibonachi(6));
            Console.WriteLine(CalculateFibonachi(1));
            Console.WriteLine(CalculateFibonachi(10));
        }

        public static int CalculateFibonachi(int count)
        {
            if (count < 0)
                return -1;
            else if (count == 0)
                return 0;
            else if (count == 1)
                return 1;

            int a = 0;
            int b = 1;
            int c = a + b;

            for (int i = 0; i < count - 3; i++)
            {
                a = b;
                b = c;
                c = a + b;
            }
            return c;
        }
    }
}