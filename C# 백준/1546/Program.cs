using System;

namespace _1546
{
    class Program
    {
        static void Main(string[] args)
        {   
            int n = int.Parse(Console.ReadLine());
            string[] grades = Console.ReadLine().Split();
            float[] loaded = new float[n];
            
            for (int i = 0; i < n; i++)
            {
                loaded[i] = float.Parse(grades[i]);
            }
            Array.Sort(loaded);
            Array.Reverse(loaded);
            float max = loaded[0];
            float ans = 0;

            for (int i = 0; i < n; i++)
            {
                ans += loaded[i] / max * 100 / n;

            }
            Console.WriteLine(ans);

        }
    }
}
