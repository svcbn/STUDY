using System;

namespace _10448
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] t = new int[45];
            for (int i = 0; i < 45; i++)
            {
                t[i] = (i + 1) * (i + 2) / 2;
            }

            for (int i = 0; i < n; i++)
            {
                int b = 0;
                int a = int.Parse(Console.ReadLine());
                for (int j = 0; j < 45; j++)
                {
                    for (int k = j; k < 45; k++)
                    {
                        for (int l = k; l < 45; l++)
                        {
                            
                            if (a == t[j] + t[k] + t[l])
                            {
                                b = 1;
                            }
                        }
                    }
                }
                Console.WriteLine(b);
            }
        }
    }
}
