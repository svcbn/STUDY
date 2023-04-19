using System.Text;
using System;

namespace _15552
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder strb = new StringBuilder();
            string[] arr = null;
            int n1 = 0;
            int n2 = 0;

            for (int i = 0; i < n; i++)
            {
                arr = Console.ReadLine().Split();
                n1 = int.Parse(arr[0]);
                n2 = int.Parse(arr[1]);
                strb.Append(n1 + n2 + "\n");
            }

            Console.WriteLine(strb);
        }
    }
}
