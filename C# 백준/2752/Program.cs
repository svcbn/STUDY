int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int a, b, c;

if(n[0] < n[1] && n[0] < n[2])
{
    a = 0;
    if (n[1] < n[2])
    {
        b = 1; c = 2;
    }
    else
    {
        b = 2; c = 1;
    }
}
else if (n[1] < n[0] && n[1] < n[2])
{
    a = 1;
    if (n[0] < n[2])
    {
        b = 0; c = 2;
    }
    else
    {
        b = 2; c = 0;
    }
}
else
{
    a = 2;
    if (n[0] < n[1])
    {
        b = 0; c = 1;
    }
    else
    {
        b = 1; c = 0;
    }
}

Console.WriteLine(n[a] + " " + n[b] + " " + n[c]);