using System;

namespace _2292
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), h = 1, count = 1;
            while(true)
            {
                if(n - h <= 0) break;
                else h += 6 * count;
                count++;
            }
            Console.Write(count);
        }
    }
}
