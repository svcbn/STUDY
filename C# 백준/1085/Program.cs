using System.Linq;
using System;

namespace _1085
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            n[2] -= n[0];
            n[3] -= n[1];
            Console.Write(n.Min());
        }
    }
}
