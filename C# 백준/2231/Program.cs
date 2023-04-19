using System;

namespace _2231
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(int.Parse(DS(s)));

            string DS(string num)
            {
                for (int a = 0; a < 10; a++)
                {
                    for (int b = 0; b < 10; b++)
                    {
                        for (int c = 0; c < 10; c++)
                        {
                            for (int d = 0; d < 10; d++)
                            {
                                for (int e = 0; e < 10; e++)
                                {
                                    for (int f = 0; f < 10; f++)
                                    {
                                        for (int g = 0; g < 10; g++)
                                        {
                                            int temp = a * 1000001 + b * 100001 + c * 10001 + d * 1001 + e * 101 + f * 11 + g * 2;
                                            if (temp == int.Parse(num)) return Convert.ToString(a) + Convert.ToString(b) + Convert.ToString(c) + Convert.ToString(d) + Convert.ToString(e) + Convert.ToString(f) + Convert.ToString(g);
                                            else if (temp > int.Parse(num)) break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return "0";
            }
        }
    }
}