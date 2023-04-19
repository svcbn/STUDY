using System;

namespace _2902
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] c = Console.ReadLine().ToCharArray();
            Console.Write(c[0]);
            for (int i = 0; i < c.Length; i++)
            {
                if(c[i] == 45)
                {
                    Console.Write(c[i + 1]);
                }
            }

        }
    }
}
