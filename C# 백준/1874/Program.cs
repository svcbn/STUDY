using System.Text;
int n = int.Parse(Console.ReadLine());
Stack<int> c = new();
StringBuilder s = new();
int a = 1;

for (int i = 0; i < n; i++)
{
    int t = int.Parse(Console.ReadLine());
    while (true)
    {
        if (c.Count == 0)
        {
            c.Push(a);
            a++;
            s.Append("+" + "\n");
        }

        if (t > c.Peek())
        {
            c.Push(a);
            a++;
            s.Append("+" + "\n");
        }
        else if (t == c.Peek())
        {
            c.Pop();
            s.Append("-" + "\n");
            break;
        }
        else
        {
            Console.WriteLine("NO");
            return;
        }
    }
}

Console.Write(s);