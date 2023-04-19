using System;

namespace _25372
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                if (s.Length > 5 && s.Length < 10)
                {
                    Console.Write("yes\n");
                }
                else
                {
                    Console.Write("no\n");
                }
            }
        }
    }
}