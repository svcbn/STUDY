using System;
using System.Collections.Generic;
namespace _5597
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            List<int> ans = new List<int>();

            for (int i = 0; i < 28; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));

            }

            for (int i = 1; i <= 30; i++)
            {
                int a = list.FindIndex(x => x == i);
                if (a == -1)
                {
                    ans.Add(i);
                }
            }
            ans.Sort();
            Console.WriteLine(ans[0]);
            Console.WriteLine(ans[1]);
        }
    }
}
