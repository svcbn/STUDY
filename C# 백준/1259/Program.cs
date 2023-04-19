using System;

namespace _1259
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string n = Console.ReadLine();
                if (n == "0") break;
                char[] c = n.ToCharArray();
                int r = 1;
                for (int i = 0; i < n.Length / 2; i++)
                {
                    if(c[i] != c[n.Length - i - 1])
                    {
                        r = 0;
                    }
                }
                if(r == 1)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
    }
}
