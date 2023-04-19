using System;
using System.Text;

namespace _1252
{
    class ex1
    {
        static void Main()
        {
            StringBuilder answer = new StringBuilder();

            string[] s = Console.ReadLine().Split();
            string a = s[0];
            string b = s[1];

            if (a.Length > b.Length)
            {
                b = b.PadLeft(a.Length, '0');
            }
            else
            {
                a = a.PadLeft(b.Length, '0');
            }

            bool up = false;
            int cnt = 0;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                if (a[i] == '1')
                {
                    cnt++;
                }
                if (b[i] == '1')
                {
                    cnt++;
                }
                if (up)
                {
                    cnt++;
                }

                if (cnt % 2 == 1)
                {
                    answer.Insert(0, "1");
                    if (cnt >= 3)
                    {
                        up = true;
                        cnt = 0;
                    }
                    else
                    {
                        up = false;
                        cnt = 0;
                    }
                }
                else
                {
                    answer.Insert(0, "0");
                    if (cnt >= 2)
                    {
                        up = true;
                        cnt = 0;
                    }
                    else
                    {
                        up = false;
                        cnt = 0;
                    }
                }
            }
            if (up)
            {
                answer.Insert(0, "1");
            }

            int len = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == '0')
                {
                    len++;
                }
                else
                {
                    break;
                }
            }
            answer.Remove(0, len);

            if (answer.Length == 0)
            {
                answer.Append("0");
            }
            Console.WriteLine(answer);
        }
    }
}