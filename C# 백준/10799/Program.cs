int n = 0;
Stack<char> stack = new Stack<char>();

string s = Console.ReadLine();
for (int i = 0; i < s.Length; i++)
{
    if (s[i] == '(') stack.Push(s[i]);
    else
    {
        if (s[i - 1] == '(')
        {
            stack.Pop();
            n += stack.Count();
        }
        else
        {
            stack.Pop();
            n++;
        }
    }
}
Console.Write(n);