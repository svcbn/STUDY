using System;

namespace _5585
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), c = 0;
            int[] m = { 500, 100, 50, 10, 5, 1 };
            n = 1000 - n;
            for (int i = 0; i < 6; i++)
            {
                c += n / m[i];
                n %= m[i];
            }
            Console.Write(c);
        }
    }
}
