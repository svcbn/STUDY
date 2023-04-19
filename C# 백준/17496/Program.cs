using System;

namespace _17496
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.Write((n[0] - 1) / n[1] * n[2] * n[3]);
        }
    }
}
