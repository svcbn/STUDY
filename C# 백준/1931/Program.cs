int n = int.Parse(Console.ReadLine());
(int, int)[] a = new (int, int)[n];
int c = 0;
int t = 0;

for (int i = 0; i < n; i++)
{
    int[] p = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    a[i] = (p[1], p[0]);
}

Array.Sort(a);

for (int i = 0; i < n; i++)
{
    if (t > a[i].Item2) continue;
    c++;
    t = a[i].Item1;
}

Console.Write(c);