using System.Text;

int n = int.Parse(Console.ReadLine());
int[] t = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
StringBuilder a = new();

Stack<int[]> c = new Stack<int[]>();

c.Push(new int[] { 100000001, 0 });

for (int i = 1; i <= n; i++)
{
    while (c.Peek()[0] < t[i - 1])
    {
        c.Pop();
    }

    a.Append(c.Peek()[1] + " ");
    c.Push(new int[] { t[i - 1], i });
}

Console.Write(a);