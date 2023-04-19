using System;

namespace _10250
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            for (int i = 0; i < r; i++)
            {
                string[] s = Console.ReadLine().Split();
                int h = int.Parse(s[0]);
                int n = int.Parse(s[2]);

                int roomnum;
                int stairnum;
                string rn;
                if(n % h == 0)
                {
                    roomnum = n / h;
                    stairnum = h;
                }
                else
                {
                    roomnum = n / h + 1;
                    stairnum = n % h;
                }

                if(roomnum < 10)
                {
                    rn = "0" + Convert.ToString(roomnum);
                }
                else
                {
                    rn = Convert.ToString(roomnum);
                }

                Console.WriteLine(stairnum + rn);
            }
        }
    }
}
