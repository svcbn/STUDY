int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
List<int> l = new List<int>();
List<int> m = new List<int>();

for (int i = 1; i <= a[0]; i++) l.Add(i);

int t = 0;
for (int i = 0; i < a[0]; i++)
{
    t += a[1] - 1;
    while (t >= l.Count) t -= l.Count;
    m.Add(l[t]);
    l.RemoveAt(t);
}
Console.Write("<" + string.Join(", ", m) + ">");