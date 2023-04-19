using System;

namespace _9086
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                string s = Console.ReadLine();
                char[] c = s.ToCharArray();

                Console.Write(c[0]);
                Console.WriteLine(c[c.Length - 1]);
            }
        }
    }
}
