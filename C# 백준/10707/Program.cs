using System;

namespace _10707
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            for (int i = 0; i < 5; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            Console.Write(n[2] > n[4] ? Math.Min(n[0] * n[4], n[1]) : Math.Min(n[0] * n[4], (n[4] - n[2]) * n[3] + n[1]));
        }
    }
}
