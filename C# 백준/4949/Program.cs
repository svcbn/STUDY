while (true)
{
    string s = Console.ReadLine();
    bool b = true;

    if (s == ".") return;
    Stack<char> stack = new Stack<char>();

    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '(' || s[i] == '[') stack.Push(s[i]);
        else if (s[i] == ')')
        {
            if (stack.Count == 0 || stack.Peek() != '(')
            {
                b = false;
                break;
            }
            else stack.Pop();
        }
        else if (s[i] == ']')
        {
            if (stack.Count == 0 || stack.Peek() != '[')
            {
                b = false;
                break;
            }
            else stack.Pop();
        }
    }

    if (stack.Count != 0) b = false;
    if (b) Console.WriteLine("yes");
    else Console.WriteLine("no");
}