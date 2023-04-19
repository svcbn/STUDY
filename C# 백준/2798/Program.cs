using System;

namespace _2798
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = 0;

            for (int i = 0; i < n[0]; i++)
            {
                for (int j = i + 1; j < n[0]; j++)
                {
                    for (int k = j + 1; k < n[0]; k++)
                    {
                        int t = 0;
                        t += c[i] + c[j] + c[k];
                        if (t > a && t <= n[1])
                        {
                            a = t;
                        }
                    }
                }
            }
            Console.WriteLine(a);
        }
    }
}
