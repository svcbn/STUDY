using System;

namespace _1924
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] s = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int d = 0;
            if (s[0] == 1) d += s[1];
            if (s[0] == 2) d += 31 + s[1];
            if (s[0] == 3) d += 59 + s[1];
            if (s[0] == 4) d += 90 + s[1];
            if (s[0] == 5) d += 120 + s[1];
            if (s[0] == 6) d += 151 + s[1];
            if (s[0] == 7) d += 181 + s[1];
            if (s[0] == 8) d += 212 + s[1];
            if (s[0] == 9) d += 243 + s[1];
            if (s[0] == 10) d += 273 + s[1];
            if (s[0] == 11) d += 304 + s[1];
            if (s[0] == 12) d += 334 + s[1];
            
            d %= 7;
            string t="";
            if (d == 0) t = "SUN";
            if (d == 1) t = "MON";
            if (d == 2) t = "TUE";
            if (d == 3) t = "WED";
            if (d == 4) t = "THU";
            if (d == 5) t = "FRI";
            if (d == 6) t = "SAT";
            Console.Write(t);
        }
    }
}
