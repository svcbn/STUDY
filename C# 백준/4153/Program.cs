using System;

namespace _4153
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] s = Console.ReadLine().Split();
                if (s[0] == "0") break;
                Console.WriteLine(isRight(s));
            }

            string isRight(string[] array)
            {
                int a = int.Parse(array[0]);
                int b = int.Parse(array[1]);
                int c = int.Parse(array[2]);
                string ans;
                if (a*a + b*b == c*c || a*a + c*c == b*b || b*b+c*c==a*a)
                {
                    ans = "right";
                }
                else
                {
                    ans = "wrong";
                }
                return ans;
            }
        }
    }
}
