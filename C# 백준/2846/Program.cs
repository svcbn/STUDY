using System;

namespace _2846
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), d=0, M, m;
            int[] r = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            M = m = r[0];
            for (int i = 1; i < n; i++)
            {
                if (r[i] > M)
                {
                    M = r[i];
                }
                else
                {   
                    M = m = r[i];
                }
                int t = M - m;
                if (t > d)
                {
                    d = t;
                }
            }
            Console.Write(d);
        }
    }
}
