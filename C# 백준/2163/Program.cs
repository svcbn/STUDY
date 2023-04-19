using System;

namespace _2163
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.Write(n[0] * n[1] - 1);
        }
    }
}
