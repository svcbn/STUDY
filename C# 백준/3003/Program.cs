using System;

namespace _3003
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] q = Console.ReadLine().Split();
            int[] a = { 1, 1, 2, 2, 2, 8 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] - int.Parse(q[i]) + " ");
            }
        }
    }
}
