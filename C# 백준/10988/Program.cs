using System;

namespace _10988
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] c = Console.ReadLine().ToCharArray();
            for (int i = 0; i < c.Length / 2; i++)
            {
                if (c[i] != c[c.Length - i - 1])
                {
                    Console.Write(0);
                    return;
                }

            }
            Console.Write(1);
        }
    }
}
