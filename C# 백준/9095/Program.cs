int t = int.Parse(Console.ReadLine());
int[] a = new int[11];
a[1] = 1;
a[2] = 2;
a[3] = 4;

for (int i = 4; i < 11; i++)
{
    a[i] = a[i - 3] + a[i - 2] + a[i - 1];
}

for (int i = 0; i < t; i++)
{
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine(a[n]);
}