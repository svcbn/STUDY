using System;
using System.Linq;

namespace _1181
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = new string[n];
            for (int i = 0; i < n; i++) s[i] = Console.ReadLine();
            var st = s.Distinct().OrderBy(x => x.Length).ThenBy(x => x);
            foreach(string a in st) Console.WriteLine(a);
        }
    }
}
