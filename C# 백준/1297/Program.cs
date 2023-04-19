using System;

namespace _1297
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            float t = MathF.Sqrt(n[1]*n[1] + n[2]*n[2]);
            Console.Write(Math.Floor(n[0] / t * n[1]) + " " + Math.Floor(n[0] / t * n[2]));
        }
    }
}
