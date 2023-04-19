using System;

namespace _10872
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int ans = 1;

            for (int i = 0; i < num; i++)
            {
                ans *= (i+1);
            }

            Console.WriteLine(ans);
        }
    }
}
