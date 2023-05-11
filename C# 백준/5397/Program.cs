using System.Text;

int n = int.Parse(Console.ReadLine());

LinkedList<char> l = new();
LinkedListNode<char> c = new('|');
StringBuilder a = new();

for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    l.Clear();
    l.AddLast(c);

    for (int j = 0; j < s.Length; j++)
    {
        switch (s[j])
        {
            case '-':
                if (c.Previous != null) l.Remove(c.Previous);
                break;
            case '<':
                if (c.Previous != null) c = c.Previous;
                break;
            case '>':
                if (c.Next != null) c = c.Next;
                break;
            default:
                l.AddBefore(c, s[j]);
                break;
        }
    }

    l.RemoveLast();
    foreach (var v in l) a.Append(v);
    a.Append("\n");
}

Console.Write(a);