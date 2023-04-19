using System;

namespace _8958
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string q = Console.ReadLine();
                char[] c = q.ToCharArray();
                int count = 1;
                int ans = 0;
                
                for (int j = 0; j < c.Length; j++)
                {
                    if (c[j] == char.Parse("O"))
                    {
                        ans += count;
                        count++;
                    }
                    else
                    {
                        count = 1;
                    }

                }
                Console.WriteLine(ans);
            }
        }
    }
}
