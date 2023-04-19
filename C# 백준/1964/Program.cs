using System;

namespace _1964
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), c = 1, a = 0;
            if(n==1)
            {
                Console.Write("5");
                return;
            }
            else
            {
                a = 5;
                while(c<n)
                {
                    c++;
                    a += (3 * c + 1);
                    a %= 45678;
                }
                Console.Write(a);
            }


        }
    }
}
