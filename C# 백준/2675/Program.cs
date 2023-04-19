using System.Text;
using System;

namespace _2675
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                StringBuilder sb = new StringBuilder();
                string[] temp = Console.ReadLine().Split();
                int m = int.Parse(temp[0]);
                char[] c = temp[1].ToCharArray();
                for (int j = 0; j < c.Length; j++)
                {
                    for (int k = 0; k < m; k++)
                    {
                        sb.Append(c[j]);
                    }
                }
                Console.WriteLine(sb);
            }
        }
    }
}
