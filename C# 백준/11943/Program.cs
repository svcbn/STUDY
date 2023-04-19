using System;

namespace _11943
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int A = int.Parse(s[0]);
            int B = int.Parse(s[1]);
            s = Console.ReadLine().Split();
            int C = int.Parse(s[0]);
            int D = int.Parse(s[1]);

            int ans = 0;
            if (A + D > B + C) ans = B + C;
            else ans = A + D;
            Console.WriteLine(ans);
        }
    }
}
