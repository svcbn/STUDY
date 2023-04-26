using System.Text;
long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
if (a[0] == a[1])
{
    Console.WriteLine("0");
    return;
}
Array.Sort(a);
long n = a[1] - a[0] - 1;
StringBuilder s = new StringBuilder(n + "\n");
for (long i = 0; i < n; i++)
{
    s.Append(a[0] + (Int64)1 + i + " ");
}
Console.WriteLine(s);