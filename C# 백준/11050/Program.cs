using System;

namespace _11050
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int n = int.Parse(s[0]);
            int k = int.Parse(s[1]);
            Console.Write(Fr(n) / Fr(n - k) / Fr(k));
            int Fr(int n)
            {
                int s = 1;
                for (int i = 0; i < n; i++) s *= n - i;
                return s;
            }
        }
    }
}
