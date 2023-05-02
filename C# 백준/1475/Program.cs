string s = Console.ReadLine();
int[] a = new int[10];
foreach (char c in s) a[c - '0']++;
a[9] += a[6];
a[6] = 0;
a[9] = a[9] / 2 + a[9] % 2;
Console.Write(a.Max());