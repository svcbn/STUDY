using System;

namespace _19698
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int m = (n[1] / n[3]) * (n[2] / n[3]);
            Console.WriteLine(m > n[0] ? n[0] : m);
        }
    }
}