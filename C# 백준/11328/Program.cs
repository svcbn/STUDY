using System.Text;
int n = int.Parse(Console.ReadLine());
StringBuilder t = new StringBuilder();
char[] a = new char[26];
char[] b = new char[26];

for (int i = 0; i < n; i++)
{
    string[] s = Console.ReadLine().Split();

    int r = 1;
    Array.Clear(a);
    Array.Clear(b);

    foreach (var v in s[0])
    {
        a[v - 'a']++;
    }
    foreach (var v in s[1])
    {
        b[v - 'a']++;
    }

    for (int j = 0; j < 26; j++)
    {
        if (a[j] != b[j])
        {
            r = 0;
            break;
        }
    }

    t.Append(r == 1 ? "Possible\n" : "Impossible\n");

}

Console.Write(t);