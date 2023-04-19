using System.Collections.Generic;
using System.Text;
using System;

namespace _11721
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            while (s.Length >= 10)
            {
                Console.WriteLine(s.Substring(0, 10));
                s = s.Remove(0, 10);
            }
            Console.WriteLine(s);
        }
    }
}
