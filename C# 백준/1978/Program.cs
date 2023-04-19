using System.Collections.Generic;
using System;

namespace _1978
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();

            int[] pn = new int[1001];
            for (int i = 2; i <1000; i++) pn[i] = i;
            for (int i = 2; i <= 1000; i++)
            {
                if (pn[i] == 0) continue;
                for (int j = i + i; j <= 1000; j+=i) pn[j] = 0;
            }
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int j = int.Parse(s[i]);
                if((Array.IndexOf(pn, j)) != -1) count++;
            }
            Console.WriteLine(count);

        }
    }
}