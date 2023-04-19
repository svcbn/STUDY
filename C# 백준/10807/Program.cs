using System;
using System.Collections.Generic;

namespace _10807
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split();
            string find = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (numbers[i] == find)
                {
                    count++;
                }
                
            }
            
            Console.WriteLine(count);
        }
    }
}
