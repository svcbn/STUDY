int[] n = new int[5];
for (int i = 0; i < 5; i++)
{
    n[i] = int.Parse(Console.ReadLine());
}
int s = 0;
foreach(int i in n)
{
    s += i;
}
Array.Sort(n);
Console.WriteLine(s / 5 + "\n" + n[2]);