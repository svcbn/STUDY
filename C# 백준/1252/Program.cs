using System.Collections.Generic;
using System.Security.Principal;
using System.Linq;
using System;

namespace _1252
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            List<char> list1 = s[0].ToList<char>();
            List<char> list2 = s[1].ToList<char>();

            
            int a = list1.Count;
            int b = list2.Count;

            List<int> temp = new List<int>();
            if(a > b)
            {
                temp.AddRange(list1.Take(a - b));
            }
            else if(a < b)
            {
                temp.Add(Convert.ToInt32(list2.Take(b - a)));
            }

            List<int> tl = new List<int>(0);

            for (int i = 0; i < list1.Count + 1; i++)
            {
                tl[i] += list1[i] + list2[i];
                if (tl[i-1] > 1)
                {
                    tl[i] += 1;
                    tl[i-1] -= 2;
                }
            }

            List<int> ans = new List<int>();
            ans.AddRange(temp);
            ans.AddRange(tl);

            foreach(var e in ans)
            {
                Console.Write(e);
            }




        }

    }
}
