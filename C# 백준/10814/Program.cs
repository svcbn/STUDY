using System.Collections.Generic;
using System;

namespace _10814
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> l = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] t = (Console.ReadLine().Split());
                l.Add(t[1], t[0]);
            }
            

        }
    }
}
