using System;

namespace _10162
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int A = 0;
            int B = 0;
            int C = 0;

            if (t % 10 != 0)
            {
                Console.Write(-1);
                return;
            }
            if (t > A) A = t / 300;
            t %= 300;
            if (t > B) B = t / 60;
            t %= 60;
            if (t > C) C = t / 10;

            Console.WriteLine(A + " " + B + " " + C);
        }
    }
}
