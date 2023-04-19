using System;

namespace _1110
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), a = 0, c = 0;

            while(true)
            {
                if (c == 0)
                {
                    if (a == n)
                    {
                        c++;
                        break;
                    }
                    else
                    {
                        c++;
                        int t = (n / 10) + (n % 10);
                        if (t >= 10)
                        {
                            t -= 10;
                            a = (n % 10) * 10 + t;
                        }
                        else
                        {
                            a = (n % 10) * 10 + t;
                        }
                    }
                }
                else
                {
                    if (a == n)
                    {
                        break;
                    }
                    else
                    {
                        c++;
                        int t = (a / 10) + (a % 10);
                        if (t >= 10)
                        {
                            t -= 10;
                            a = (a % 10) * 10 + t;
                        }
                        else
                        {
                            a = (a % 10) * 10 + t;
                        }
                    }
                }
            }
            Console.Write(c);
            
        }
    }
}
