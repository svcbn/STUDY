using System;

namespace _2010
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                a += int.Parse(Console.ReadLine());
            }
            Console.Write(a - n + 1);
        }
    }
}
