int count = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    Stack<char> stack = new Stack<char>();
    for (int j = 0; j < s.Length; j++)
    {
        if (stack.Count == 0) stack.Push(s[j]);
        else if (stack.Peek() == s[j]) stack.Pop();
        else stack.Push(s[j]);
    }

    if (stack.Count == 0) count++;
}

Console.Write(count);