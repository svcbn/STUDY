using System.Linq;
using System;

namespace _2745
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            char[] c = s[0].ToCharArray();
            Array.Reverse(c);
            double a = 0;
            for (int i = 0; i < c.Length; i++)
            {
                int t = (c[i] > 64 ? (c[i] - 55) : (c[i] - 48));
                a += t * Math.Pow(double.Parse(s[1]), i);
            }
            Console.Write(a);
        }
    }
}
