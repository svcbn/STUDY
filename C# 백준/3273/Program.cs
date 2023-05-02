int n = int.Parse(Console.ReadLine());
int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int x = int.Parse(Console.ReadLine());
int[] s = new int[2000000];
int c = 0;

foreach (int i in a)
{
    int t = 0;
    if (x - i > 0) t = x - i;
    if (s[t] == 1)
    {
        c++;
    }
    s[i]++;
}

Console.Write(c);