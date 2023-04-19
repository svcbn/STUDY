using System;

namespace _15964
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] q = Console.ReadLine().Split();
            Console.WriteLine(AB(q[0], q[1]));

            double AB(string A, string B)
            {
                double a = double.Parse(A);
                double b = double.Parse(B);
                return (a + b) * (a - b);
            }
        }

    }
}
