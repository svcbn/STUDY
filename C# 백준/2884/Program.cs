using System;

namespace _2884
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] time = Console.ReadLine().Split();
            int H = int.Parse(time[0]);
            int M = int.Parse(time[1]);

            M -= 45;
            if(M < 0)
            {
                M += 60;
                H -= 1;
                if(H < 0)
                {
                    H += 24;
                }
            }
            Console.Write(H + " " + M);
        }
    }
}
