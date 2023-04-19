using System;

namespace _1100
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;
            for (int i = 0; i < 8; i++)
            {
                string s = Console.ReadLine();
                for (int j = 0; j < 4; j++)
                {
                    if (i % 2 == 0 && s[2*j] == char.Parse("F"))
                    {
                        c++;
                    }
                    else if(i % 2 != 0 && s[2*j+1] == char.Parse("F"))
                    {
                        c++;
                    }
                }
            }
            Console.Write(c);
        }
    }
}
