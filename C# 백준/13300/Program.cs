int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] a = new int[12];

for (int i = 0; i < n[0]; i++)
{
    int[] t = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    a[(t[1] - 1) * 2 + t[0]]++;
}

int r = 0;
foreach (int i in a)
{
    r += i % n[1] == 0 ? i / n[1] : i / n[1] + 1;
}
Console.Write(r);