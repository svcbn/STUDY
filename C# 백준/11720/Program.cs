using System;

namespace _11720
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int ans = 0;
            string q = Console.ReadLine();
            char[] c = q.ToCharArray();
            for (int i = 0; i < n; i++)
            {
                ans += int.Parse(Convert.ToString(c[i]));
                
            }
            Console.WriteLine(ans);
        }
    }
}
