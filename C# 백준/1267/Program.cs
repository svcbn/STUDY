Console.ReadLine();
int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int A = 0, B = 0;
string s = "";

foreach(int i in a)
{
    A += (i / 30 + 1);
    B += (i / 60 + 1);
}

A *= 10;
B *= 15;

if (A < B) s += "Y " + A;
else if (A > B) s += "M " + B;
else s += "Y M " + A;

Console.WriteLine(s);