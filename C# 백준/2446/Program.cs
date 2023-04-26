int n = int.Parse(Console.ReadLine());
string s = "";
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i; j++)
    {
        s += " ";
    }
    for (int k = 2 * (n - i) - 1; k > 0; k--)
    {
        s += "*";
    }
    s += "\n";
}
for (int i = 1; i < n; i++)
{
    for (int j = n - 1; j > i; j--)
    {
        s += " ";
    }
    for (int k = 0; k < 2 * i + 1; k++)
    {
        s += "*";
    }
    s += "\n";
}
Console.WriteLine(s);