using System;

namespace _4344
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                float[] t = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
                float s, c;
                s = c = 0;
                for (int j = 0; j < t[0]; j++)
                {
                    s += t[j + 1];
                }
                for (int j = 0; j < t[0]; j++)
                {
                    if(s/t[0]<t[j+1]) c++;
                }
                Console.WriteLine(string.Format("{0:0.000}", c / t[0] * 100 ) + "%");
            }
        }
    }
}
