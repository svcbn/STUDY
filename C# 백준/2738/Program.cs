using System;
using System.Collections;
using System.Linq;


namespace _2738
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split();
            int m = int.Parse(size[0]);
            int n = int.Parse(size[1]);

            int[,] array1 = new int[m,n];
            int[,] array2 = new int[m,n];

            for(int i = 0; i < m; i++)
            {
                string[] x = Console.ReadLine().Split();

                for (int j = 0; j < n; j++)
                {
                    int temp = int.Parse(x[j]);
                    array1[i,j] = temp;
                }
            }

            for(int i = 0; i < m; i++)
            {
                string[] x = Console.ReadLine().Split();

                for (int j = 0; j < n; j++)
                {
                    int temp = int.Parse(x[j]);
                    array2[i,j] = temp;
                }
            }

            int[,] ans = new int[m,n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ans[i,j] = array1[i,j] + array2[i,j];
                }
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(ans[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
