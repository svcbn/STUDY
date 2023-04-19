using System;

namespace _10984
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                float s = 0, g = 0;
                int y = int.Parse(Console.ReadLine());
                for (int j = 0; j < y; j++)
                {
                    float[] a = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);
                    s += a[0];
                    g += a[0] * a[1];
                }
                Console.WriteLine(s + " " + g / s);
            }
        }
    }
}
