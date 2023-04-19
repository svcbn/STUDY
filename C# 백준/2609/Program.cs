using System;

namespace _2609
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int gcd = GCD(a, b);

            Console.WriteLine(gcd);
            Console.WriteLine(a * b / gcd);

            int GCD(int a, int b)
            {
                if(a < b)
                {
                    int temp = a;
                    a = b;
                    b = temp;
                }

                if (b == 0)
                {
                    return a;
                }

                if (a % b == 0)
                {
                    return b;
                }
                else
                {
                    return GCD(b, a % b);
                }
            }
        }
    }
}
