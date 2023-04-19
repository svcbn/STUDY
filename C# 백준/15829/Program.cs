using System;

namespace _15829
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), m = 1234567891;
            char[] c = (Console.ReadLine()).ToCharArray();
            long a = 0, r = 1;
            for (int i = 0; i < n; i++)
            {
                a += (c[i] - 96) * r;
                r = r * 31 % m;
            }
            Console.Write(a % m);
        }
    }
}
