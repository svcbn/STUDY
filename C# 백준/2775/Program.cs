using System;

namespace _2775
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[15, 15];
            for (int i = 0; i < 15; i++)
            {
                a[0, i] = i;
            }
            for (int i = 1; i < 15; i++)
            {
                for (int j = 1; j < 15; j++)
                {
                    a[i, j] = a[i - 1, j] + a[i, j - 1];
                }
            }

            int m = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < m; i++)
            {
                int k = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(a[k, n]);

            }
        }



    }
}

