int[] d = new int[1000001];
d[1] = 0;

int n = int.Parse(Console.ReadLine());
for (int i = 2; i <= n; i++)
{
    d[i] = d[i - 1] + 1;
    if (i % 2 == 0) d[i] = Math.Min(d[i], d[i / 2] + 1);
    if (i % 3 == 0) d[i] = Math.Min(d[i], d[i / 3] + 1);
}
Console.Write(d[n]);