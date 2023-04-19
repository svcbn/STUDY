using System;
using System.Linq;

namespace _2562
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[9];
            for (int i = 0; i < 9; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(num.Max());
            Console.WriteLine(Array.IndexOf(num, num.Max()) + 1);
        }
    }
}
