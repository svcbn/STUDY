using System;
using System.Collections.Generic;

namespace _10871
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] q = Console.ReadLine().Split();
            int n = int.Parse(q[1]);
            int size = int.Parse(q[0]);

            string[] numbers = Console.ReadLine().Split();
            List<int> list = new List<int>();
        
            for (int i = 0; i < size; i++)
            {
                int temp = int.Parse(numbers[i]);
                if (temp < n)
                {
                    list.Add(temp);
                }
            }
            Console.Write(string.Join(" ", list));
        }
    }
}
