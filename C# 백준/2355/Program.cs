using System;

namespace _2355
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] n = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            Array.Sort(n);
            Console.Write((n[0] + n[1]) * (n[1] - n[0] + 1) / 2);
        }
    }
}
