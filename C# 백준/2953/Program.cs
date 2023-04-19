using System;

namespace _2953
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = 0, h = 0;
            for (int i = 0; i < 5; i++)
            {
                int[] s = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int t = s[0] + s[1] + s[2] + s[3];
                if(t > h)
                {
                    h = t;
                    w = i+1;
                }
            }
            Console.Write(w + " " + h);
        }
    }
}
