using System;

namespace _14681
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > 0)
            {
                if(n2 > 0)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(4);
                }
            }
            else
            {
                if(n2 > 0)
                {
                    Console.WriteLine(2);
                }
                else
                {
                    Console.WriteLine(3);
                }
            }
        }
    }
}
