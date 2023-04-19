using System;

namespace _25314
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while(n > 3)
            {
                Console.Write("long ");
                n -= 4;
            }
            Console.Write("int");
        }
    }
}
