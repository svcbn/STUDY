using System;

namespace _2908
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] q = Console.ReadLine().Split();
            char[] a = q[0].ToCharArray();
            char[] b = q[1].ToCharArray();

            string x = string.Join("", switch13(a));
            string y = string.Join("", switch13(b));

            if(int.Parse(x) > int.Parse(y))
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(y);
            }

            char[] switch13(char[] c)
            {
                char temp = c[0];
                c[0] = c[2];
                c[2] = temp;

                return c;
            }
        }

    }
}
