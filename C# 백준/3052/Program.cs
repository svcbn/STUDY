using System;
using System.Linq;

namespace _3052
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            
            for (int i = 0; i < 10; i++)
            {
                int temp = int.Parse(Console.ReadLine()) % 42;
                num[i] = temp;
            }
            int[] ans = num.Distinct().ToArray();
            Console.WriteLine(ans.Length);
        }
    }
}
