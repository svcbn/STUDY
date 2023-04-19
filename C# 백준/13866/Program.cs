using System;

namespace _13866
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.Write(MathF.Abs(n[0] + n[3] - n[1] - n[2]));

        }
    }
}
