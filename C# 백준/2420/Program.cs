using System;

namespace _2420
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] f = Console.ReadLine().Split();
            double n = double.Parse(f[0]) - double.Parse(f[1]);
            if (n < 0)
            {
                n *= -1;
            }
            Console.WriteLine(n);
        }
    }
}
