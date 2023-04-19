using System;

namespace _11382
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split();
            Console.WriteLine(decimal.Parse(n[0]) + decimal.Parse(n[1]) + decimal.Parse(n[2]));
        }
    }
}
