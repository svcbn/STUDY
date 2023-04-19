using System;

namespace _10952
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string[] num = Console.ReadLine().Split();
                if(num[0] == "0" && num[1] == "0")
                {
                    break;
                }
                else
                {
                Console.WriteLine(int.Parse(num[0]) + int.Parse(num[1]));
                }
            }
        }
    }
}
