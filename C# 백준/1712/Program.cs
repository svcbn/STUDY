using System;

namespace _1712
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.Write(a[2] > a[1] ? a[0] / (a[2] - a[1]) + 1 : -1);
        }
    }
}
