using System;

namespace _1252
{
    public class ex2
    {
        string Solve(string a, string b)
        {
            if (a.Length != b.Length)
            {
                while (a.Length < b.Length)
                    a = a.Insert(0, "0");
                while (a.Length > b.Length)
                    b = b.Insert(0, "0");
            }

            string ret = "";
            int nextAdd = 0;
            for (int i = a.Length - 1; i >= 0; --i)
            {
                int aN = int.Parse(a[i].ToString());
                int bN = int.Parse(b[i].ToString());

                int sum = aN + bN + nextAdd;
                if (sum > 1)
                {
                    nextAdd = 1;
                    sum %= 2;
                }
                else
                    nextAdd = 0;

                ret = sum.ToString() + ret;
            }

            if (nextAdd > 0)
                ret = "1" + ret;

            while (ret.StartsWith("0"))
                ret = ret.Remove(0, 1);

            if (ret.Length == 0)
                return "0";

            return ret;
        }
        var input = Console.ReadLine().Split(" ");
        Console.WriteLine(Solve(input[0], input[1]));
    }
}