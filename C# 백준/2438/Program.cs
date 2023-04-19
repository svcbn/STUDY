using System;

namespace _2438
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                    
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
