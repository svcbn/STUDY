int[] a = new int[20];
for (int i = 0; i < 20; i++) a[i] = i + 1;

for (int i = 0; i < 10; i++)
{
    int[] c = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    
    for (int k = 0; k < 2; k++) c[k]--;

    int n = c[1] - c[0] + 1;
    int[] r = new int[n];

    for (int j = 0; j < n; j++)
    {
        r[j] = a[c[1]-j];
    }

    for (int j = 0; j < n; j++)
    {
        a[j+c[0]] = r[j];
    }
}

string s = "";
foreach(int i in a)
{
    s += i + " ";
}
Console.WriteLine(s);