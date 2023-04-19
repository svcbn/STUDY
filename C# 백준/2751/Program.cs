using System.Text;
using System;

namespace _2751
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] l = new int[n];
            for (int i = 0; i < n; i++)
            {
                l[i] = (int.Parse(Console.ReadLine()));
            }
            Array.Sort(l);
            StringBuilder srb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                srb.Append(l[i] + "\n");
            }
            Console.Write(srb.ToString());
        }
    }
}
