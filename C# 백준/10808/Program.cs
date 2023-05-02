string s = Console.ReadLine();
int[] a = new int[26];
foreach (char c in s) a[c - 'a']++;
Console.Write(string.Join(" ", a));