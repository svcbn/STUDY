using System.Text;
using System;

namespace _2742
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder strb = new StringBuilder();

            for (int i = n; i > 0; i--)
            {
                strb.Append(i + "\n");
            }
            Console.WriteLine(strb);
        }
    }
}
