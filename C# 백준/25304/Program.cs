using System;

namespace _25304
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                int[] t = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                n -= t[0] * t[1];
            }
            Console.Write(n == 0 ? "Yes" : "No");
        }
    }
}
