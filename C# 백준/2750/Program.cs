using System.Collections.Generic;
using System;

namespace _2750
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] s = new int[n];
            for (int i = 0; i < n; i++)
            {
                s[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(s, (a, b) => (a < b) ? -1 : 1);
            Console.WriteLine(string.Join("\n", s));
        }
    }
}
