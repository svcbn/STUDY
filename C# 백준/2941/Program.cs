using System.Linq;
using System.Collections.Generic;
using System;

namespace _2941
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
            var s = Console.ReadLine();
            for (int i = 0; i < 8; i++)
            {
                s = s.Replace(a[i],"A");
            }
            Console.Write(s.Length);
        }
    }
}
