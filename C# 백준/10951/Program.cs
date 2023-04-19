using System;

namespace _10951
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == null)
                {
                    break;
                }
                else
                {
                    string[] str = input.Split();
                    Console.WriteLine(int.Parse(str[0]) + int.Parse(str[1]));
                }
            }
        }
    }
}
