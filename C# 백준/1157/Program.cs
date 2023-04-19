using System;


namespace _1157
{
    class Program
    {
        public static void Main(string[] args)
        {
            char[] c = Console.ReadLine().ToUpper().ToCharArray();
            int[] n = new int[26];

            for (int i = 0; i < c.Length; i++)
            {
                n[Convert.ToInt32(c[i]) - 65]++;
            }

            int ans = maxAlphabet(n);
            if (ans == -1)
            {
                Console.WriteLine("?");
            }
            else
            {
                Console.WriteLine(Convert.ToChar(ans + 65));
            }

            int maxAlphabet(int[] array)
            {
                int m = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > m)
                    {
                        m = array[i];
                    }
                }
                int repeatCount = 0;
                int ans = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == m)
                    {
                        repeatCount++;
                        if (repeatCount > 1)
                        {
                            return -1;
                        }
                        ans = i;
                    }
                }
                return ans;
            }
        }
    }


}

