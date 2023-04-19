using System;
using System.Collections.Generic;
using System.Linq;

namespace _10818
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();
            int[] num = new int[size];

            for (int i = 0; i < size; i++)
            {
                num[i] = int.Parse(arr[i]);
            }
            Array.Sort(num);
            Console.Write(num[0] + " " + num[size - 1]);
        }
    }
}
