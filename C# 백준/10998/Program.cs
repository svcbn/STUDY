﻿using System;

namespace _10998
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(int.Parse(input[0]) + int.Parse(input[1]));
            Console.WriteLine(int.Parse(input[0]) - int.Parse(input[1]));
            Console.WriteLine(int.Parse(input[0]) * int.Parse(input[1]));
            Console.WriteLine(int.Parse(input[0]) / int.Parse(input[1]));
            Console.WriteLine(int.Parse(input[0]) % int.Parse(input[1]));
        }
    }
}
