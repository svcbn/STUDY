int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] a = new int[n[0]];
int c = 0;
for (int i = 0; i < n[0]; i++) a[i] = int.Parse(Console.ReadLine());

for (int i = n[0] - 1; i >= 0; i--)
{
    if (n[1] == 0) break;
    while (n[1] >= a[i])
    {
        c += (n[1] / a[i]);
        n[1] %= a[i];
    }
}

Console.Write(c);