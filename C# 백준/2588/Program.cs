using System;

namespace _2588
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a * (b % 10));
            Console.WriteLine(a * ((b % 100) / 10));
            Console.WriteLine(a * ((b / 100)));
            Console.WriteLine(a * b);
        }
    }
}
