using System;

namespace _2920
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] n = Console.ReadLine().Split();
            int[] s = new int[8];
            for (int i = 0; i < 8; i++)
            {
                s[i] = int.Parse(n[i]);
            }
            if (s[0] < s[1] && s[1] < s[2] && s[2] < s[3] && s[3] < s[4] && s[4] < s[5] && s[5] < s[6] && s[6] < s[7])
            {
                Console.WriteLine("ascending");
            }
            else if (s[0] > s[1] && s[1] > s[2] && s[2] > s[3] && s[3] > s[4] && s[4] > s[5] && s[5] > s[6] && s[6] > s[7])
            {
                Console.WriteLine("descending");
            }
            else
            {
                Console.WriteLine("mixed");
            }
        }
    }
}
