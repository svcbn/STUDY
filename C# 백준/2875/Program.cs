using System;

namespace _2875
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int t = Math.Min(Math.Min(n[0] / 2, n[1]), (n[0] + n[1] - n[2]) / 3);
            
            Console.Write(t);

        }
    }
}
