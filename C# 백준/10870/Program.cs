using System;

namespace _10870
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ans = fibn(n);
            Console.WriteLine(ans);

            int fibn(int n)
            {
                if(n==0) return 0;
                if(n==1) return 1;

                return fibn(n - 1) + fibn(n - 2);
            }
        }
    }
}
