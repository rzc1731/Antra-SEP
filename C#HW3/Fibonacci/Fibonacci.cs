// See https://aka.ms/new-console-template for more information
using System;

namespace Fibonacci
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }

        public static int Fibonacci(int k)
        {
            if (k == 1 || k == 2)
            {
                return 1;
            }
            int a = 1;
            int b = 1;
            int c = 0;
            for (int i=2; i< k; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
    }
}

