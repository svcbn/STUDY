using System;

namespace _2480
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dice = Console.ReadLine().Split();
            int a = int.Parse(dice[0]);
            int b = int.Parse(dice[1]);
            int c = int.Parse(dice[2]);
            int ans = 0;
            if (a == b)
            {
                if (b == c)
                {
                    ans = 10000 + a * 1000;
                }
                else
                {
                    ans = 1000 + a * 100;
                }
            }
            else if(a > b)
            {
                if (b == c)
                {
                    ans = 1000 + b * 100;
                }
                else
                {
                    if(a == c)
                    {
                        ans = 1000 + a * 100;
                    }
                    else if(a > c)
                    {
                        ans = a * 100;
                    }
                    else
                    {
                        ans = c * 100;
                    }
                }

            }
            else
            {
                if (b == c)
                {
                    ans = 1000 + b * 100;
                }
                else
                {
                    if (a == c)
                    {
                        ans = 1000 + a * 100;
                    }
                    else if (b > c)
                    {
                        ans = b * 100;
                    }
                    else
                    {
                        ans = c * 100;
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
