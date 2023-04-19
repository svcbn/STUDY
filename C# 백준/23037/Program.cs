using System;

namespace _23037
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ans = 0;
            for (int i = 0; i < 5; i++)
            {
                ans += (n % 10) * (n % 10) * (n % 10) * (n % 10) * (n % 10);
                n /= 10;
            }
            Console.WriteLine(ans);
        }
    }
}
