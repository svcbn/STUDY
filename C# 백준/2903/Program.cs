using System;

namespace _2903
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double a = 2;
            for (int i = 0; i < n; i++)
            {
                a += a - 1;
            }
            Console.Write(a * a);

        }
    }
}
