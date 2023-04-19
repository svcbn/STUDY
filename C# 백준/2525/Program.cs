using System;

namespace _2525
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ct = Console.ReadLine().Split();
            int h = int.Parse(ct[0]);
            int m = int.Parse(ct[1]);
            int cm = 0;
            int ch = 0;

            int CT = int.Parse(Console.ReadLine());
            if (CT >= 60)
            {
                ch = CT / 60;
                cm = CT % 60;
            }
            else
            {
                cm = CT;
            }

            m += cm;
            if (m >= 60)
            {
                m -= 60;
                h += 1;
            }

            h += ch;
            if(h >= 24)
            {
                h -= 24;
            }

            Console.WriteLine(h + " " + m);
        }
    }
}
