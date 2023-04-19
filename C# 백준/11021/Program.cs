using System.Text;
using System;

namespace _11021
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = null;
            StringBuilder strb = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                arr = Console.ReadLine().Split();
                strb.Append("Case #" + i + ": " + arr[0] + " + " + arr[1] + " = " + (int.Parse(arr[0]) + int.Parse(arr[1])) + "\n");
            }
            Console.WriteLine(strb);
        }
    }
}
