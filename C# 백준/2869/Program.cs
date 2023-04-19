using System;

namespace _2869
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] n = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long a = (n[2] - n[0]), b = (n[0] - n[1]), t = a/b;
            if(a%b != 0) t++;
            Console.Write(t + 1);

        }
    }
}
