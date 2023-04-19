using System;
using System.Text;

namespace _2741
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            StringBuilder numbers = new StringBuilder();
            
            for (int i = 1; i <= num; i++)
            {
                numbers.AppendLine(i.ToString());
            }
            
            Console.WriteLine(numbers);
        }
    }
}
