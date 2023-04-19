using System;

namespace _2167
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split();
            int n = int.Parse(size[0]);
            int m = int.Parse(size[1]);

            int[,] array = new int[n, m];
            for (int a = 0; a < n; a++)
            {
                string[] str = Console.ReadLine().Split();
                for (int b = 0; b < m; b++)
                {
                    array[a, b] = int.Parse(str[b]);
                }
            }

            int t = int.Parse(Console.ReadLine());
            for (int c = 0; c < t; c++)
            {
                string[] ijxy = Console.ReadLine().Split();
                int i = int.Parse(ijxy[0]);
                int j = int.Parse(ijxy[1]);
                int x = int.Parse(ijxy[2]);
                int y = int.Parse(ijxy[3]);

                int ans = 0;

                for (int a = i - 1; a < x; a++)
                {
                    for (int b = j - 1; b < y; b++)
                    {
                        ans += array[a, b];
                    }
                }

                Console.WriteLine(ans);
            }
        }
    }
}
