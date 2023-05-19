using System.Text;
int n = int.Parse(Console.ReadLine());
StringBuilder a = new();
int[] d = new int[10000];
int p = 0;

for (int i = 0; i < n; i++)
{
    string[] s = Console.ReadLine().Split();
    switch (s[0])
    {
        case "push":
            Push(int.Parse(s[1]));
            break;
        case "pop":
            Pop();
            break;
        case "size":
            Size();
            break;
        case "empty":
            Empty();
            break;
        case "top":
            Top();
            break;
    }
}

Console.Write(a);

void Push(int c)
{
    d[p] = c;
    p++;
}

void Pop()
{
    if (p == 0)
    {
        a.Append(-1 + "\n");
    }
    else
    {
        a.Append(d[p - 1] + "\n");
        p--;
    }
}

void Size()
{
    a.Append(p + "\n");
}

void Empty()
{
    if (p == 0)
    {
        a.Append(1 + "\n");
    }
    else
    {
        a.Append(0 + "\n");
    }
}

void Top()
{
    if (p == 0)
    {
        a.Append(-1 + "\n");
    }
    else
    {
        a.Append(d[p - 1] + "\n");
    }
}