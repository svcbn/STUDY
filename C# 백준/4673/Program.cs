using System.Security.Principal;
using System.Collections.Generic;
using System;

namespace _4673
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            for (int i = 1; i < 10000; i++)
            {
                l.Add(i);
            }
            for (int i = 1; i < 10000; i++)
            {
                int t = i;
                int s = t;
                while(t>0)
                {
                    s += t % 10;
                    t /= 10;
                }
                

                l.Remove(s);
            }
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }

        }
    }
}
