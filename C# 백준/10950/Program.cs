using System;

namespace _10950
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] temp = Console.ReadLine().Split();
                Console.WriteLine(int.Parse(temp[0])+int.Parse(temp[1]));
            }
        }
    }
}
