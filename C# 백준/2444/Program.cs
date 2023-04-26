int n = int.Parse(Console.ReadLine());
string s = "";
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i + 1; j++)
    {
        s += "*";
    }
    for (int k = 2 * (n - i); 2 * (k - 2) > 0; k--)
    {
        s += " ";
    }
    for (int j = 0; j < i + 1; j++)
    {
        s += "*";
    }
    s += "\n";
}
for (int i = 1; i < n; i++)
{
    for (int j = n; j > i; j--)
    {
        s += "*";
    }
    for (int k = 0; k < 2 * i; k++)
    {
        s += " ";
    }
    for (int j = n; j > i; j--)
    {
        s += "*";
    }
    s += "\n";
}
Console.WriteLine(s);