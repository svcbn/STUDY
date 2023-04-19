using System.Collections.Generic;
using System.Linq;
using System;

namespace _1919
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> a, b;
            a = Console.ReadLine().ToList<char>();
            b = Console.ReadLine().ToList<char>();
            for (int i = 0; i < a.Count; i++)
            {
                Console.Write(a[i]);
            }
            for (int i = 0; i < b.Count; i++)
            {
                Console.Write(b[i]);
            }

            for (int i = 0; i < a.Count; i++)
            {
                int t = b.FindIndex(x => x == a[i]);
                Console.WriteLine(t);
                if (t != -1)
                {
                    a.RemoveAt(i);
                    b.RemoveAt(t);
                    i--;
                }
            }
            Console.Write(a.Count + b.Count);
        }
    }
}
