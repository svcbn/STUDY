int n = int.Parse(Console.ReadLine());
Stack<int> s = new();
int a = 0;
for (int i = 0; i < n; i++)
{
    int t = int.Parse(Console.ReadLine());
    if (t == 0)
    {
        s.Pop();
    }
    else
    {
        s.Push(t);
    }
}

foreach (int i in s)
{
    a += i;
}

Console.Write(a);