using System;

namespace _2475
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] q = Console.ReadLine().Split();
            
            Console.WriteLine(check(q));

            int check(string[] str)
            {
                int ans = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    ans += int.Parse(str[i]) * int.Parse(str[i]);
                }
                return ans % 10;
            }
        }
    }
}
