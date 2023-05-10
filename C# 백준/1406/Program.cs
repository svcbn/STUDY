using System.Text;

LinkedList<char> l = new();
LinkedListNode<char> c = new('0');

foreach (var v in Console.ReadLine().ToCharArray())
{
    l.AddLast(v);
}
l.AddLast(c);

int n = int.Parse(Console.ReadLine());
StringBuilder a = new();

for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    switch (s[0])
    {
        case 'L':
            if (c.Previous != null) c = c.Previous;
            break;
        case 'D':
            if (c.Next != null) c = c.Next;
            break;
        case 'B':
            if (c.Previous != null) l.Remove(c.Previous);
            break;
        case 'P':
            l.AddBefore(c, s[2]);
            break;
    }
}

foreach (var v in l) a.Append(v);
a.Remove(a.Length - 1, 1);
Console.WriteLine(a);