using System;

namespace _2744
{
    class Program
    {
        static void Main(string[] args)
        {
            string q = Console.ReadLine();
            char[] c = q.ToCharArray();

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] >= 'A' && c[i] <= 'Z')
                {
                    c[i] = Convert.ToChar(Convert.ToInt32(c[i] + 32));
                }
                else if(c[i] >= 'a' && c[i] <= 'z')
                {
                    c[i] = Convert.ToChar(Convert.ToInt32(c[i] - 32));
                }
                Console.Write(c[i]);
            }
            

        }
    }
}
