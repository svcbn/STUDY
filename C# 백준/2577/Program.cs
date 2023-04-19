using System;

namespace _2577
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            for (int i = 0; i < 3; i++)
            {
                num *= int.Parse(Console.ReadLine());
            }
            string ans = Convert.ToString(num);

            
            string[] str = new string[ans.Length];
            for (int i = 0; i < ans.Length; i++)
            {
                str[i] = ans.Substring(i, 1);
            }

            for (int i = 0; i < 10; i++)
            {
                int count = 0;
                for (int j = 0; j < ans.Length; j++)
                {
                    if (int.Parse(str[j]) == i)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
