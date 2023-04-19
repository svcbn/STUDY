using System;

namespace _2455
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0 , c = 0;
            for (int i = 0; i < 4; i++)
            {
                int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                c += n[1] - n[0];
                if(c > m)
                {
                    m = c;
                }
            }
            Console.Write(m);
        }
    }
}
